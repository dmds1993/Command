using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class Ligth : ILigth
    {
        public bool isOn { get; set; }
        public void Off()
        {
            isOn = false;
        }

        public void On()
        {
            isOn = true;
        }
    }
}
