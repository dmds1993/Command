using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public interface IGarageDoor
    {
        void Up();
        void Down();
        void Stop();
        void LigthOn();
        void LigthOff();
    }
}
