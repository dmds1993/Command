using Command.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class Command : ICommand
    {
        public ICommand slot { get; set; }
        public Command() { }

        public Command(ICommand slot)
        {
            this.slot = slot;
        }
        public void Execute()
        {
            slot.Execute();
        }
    }
}
