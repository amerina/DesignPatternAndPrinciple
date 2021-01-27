using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class CloseFridgeDoorCommand : ICommand
    {
        public ElephantIntoFridge Fridge { get; private set; }

        public CloseFridgeDoorCommand(ElephantIntoFridge fridge)
        {
            Fridge = fridge;
        }
        public void Execute()
        {
            Fridge.CloseFridgeDoor();
        }
    }
}
