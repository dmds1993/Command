using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoteControl remoteControl = new RemoteControl();

            Ligth ligth = new Ligth();
            LigthOnCommand ligthGarageDoor = new LigthOnCommand(ligth);
            LigthOffCommand ligthOffCommand = new LigthOffCommand(ligth);

            GarageDoor garageDoor = new GarageDoor(ligth);
            GarageDoorCommandOpen garageDoorCommandOpen = new GarageDoorCommandOpen(garageDoor);
            GarageDoorCommandClose garageDoorCommandClose = new GarageDoorCommandClose(garageDoor);

            remoteControl.SetCommand(1, garageDoorCommandOpen, garageDoorCommandClose);
            remoteControl.SetCommand(2, ligthGarageDoor, ligthOffCommand);

            remoteControl.onButtonWasPushed(1);
            remoteControl.onButtonWasPushed(2);

            Console.WriteLine("Hello World!");
        }
    }
}
