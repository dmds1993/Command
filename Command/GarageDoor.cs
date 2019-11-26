using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class GarageDoor : IGarageDoor
    {
        private readonly ILigth ligth;

        public GarageDoor(ILigth ligth)
        {
            this.ligth = ligth;
        }
        public void Down()
        {
            Console.WriteLine("Down door");
        }

        public void LigthOff()
        {
            ligth.Off();
        }

        public void LigthOn()
        {
            ligth.On();
        }

        public void Stop()
        {
            Console.WriteLine("Stoped");
        }

        public void Up()
        {
            Console.WriteLine("up door");
        }
    }
}
