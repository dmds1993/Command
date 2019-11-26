using Command.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    class LigthOffCommand : ICommand
    {
        private readonly ILigth ligth;
        public LigthOffCommand(ILigth ligth)
        {
            this.ligth = ligth;
        }
        public void Execute()
        {
            ligth.Off();
        }
    }
}
