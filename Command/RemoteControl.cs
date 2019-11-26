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
        public RemoteControl()
        {
            onCommands = new List<ICommand>();
            offCommands = new List<ICommand>();

            for(var i = 0; i < 7; i++)
            {
                onCommands.Add(new Command());
                offCommands.Add(new Command());
            }
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
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

        public string ToString
        {
            get
            {
                var offCommands = JsonSerializer.Serialize(this.onCommands);
                var onCommands = JsonSerializer.Serialize(this.offCommands);
                return $"onCommands = {onCommands} offCommands = {offCommands}";
            }
        }
    }
}
