using Command.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class LigthOnCommand : ICommand
    {
        private readonly ILigth ligth;

        public LigthOnCommand(ILigth ligth)
        {
            this.ligth = ligth;
        }

        public void Execute()
        {
            Console.WriteLine("Ligth is ON");
            ligth.On();   
        }
    }
}
