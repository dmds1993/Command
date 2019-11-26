using Command.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class SimpleRemoteControl
    {
        private ICommand slot { get; set; }

        public void SetCommand(ICommand slot)
        {
            this.slot = slot;
        }

        public void ButtonWasPressed()
        {
            slot.Execute();
        }
    }
}
