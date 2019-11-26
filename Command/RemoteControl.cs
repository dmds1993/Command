using Command.interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Command
{
    public class RemoteControl
    {
        private List<ICommand> onCommands;
        private List<ICommand> offCommands;

        private List<ICommand> prevOnCommands;
        private List<ICommand> prevOffCommands;
        public RemoteControl()
        {
            onCommands = new List<ICommand>();
            offCommands = new List<ICommand>();
            prevOnCommands = new List<ICommand>();
            prevOffCommands = new List<ICommand>();

            for(var i = 0; i < 7; i++)
            {
                onCommands.Add(new Command());
                offCommands.Add(new Command());
            }
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            prevOnCommands.Add(onCommand);
            prevOffCommands.Add(offCommand);

            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }

        public void onButtonWasPushed(int slot)
        {
            onCommands[slot].Execute();
        }

        public void offButtonWasPushed(int slot)
        {
            offCommands[slot].Execute();
        }

        public void Undo()
        {
            onCommands.Remove(prevOnCommands.FindLast());
            offCommands.Remove(prevOffCommands.FindLast());
        }
    }
}
