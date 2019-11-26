using Command.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class GarageDoorCommandClose : ICommand
    {
        private readonly IGarageDoor garageDoor;
        public GarageDoorCommandClose(GarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }
        public void Execute()
        {
            garageDoor.Down();
        }
    }
}
