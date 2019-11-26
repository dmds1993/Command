using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public interface ILigth
    {
        bool isOn { get; set; }
        void On();
        void Off();
    }
}
