using Command.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class GarageDoorCommandOpen : ICommand
    {
        private readonly IGarageDoor garageDoor;
        public GarageDoorCommandOpen(IGarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }
        public void Execute()
        {
            garageDoor.Up();
        }
    }
}
