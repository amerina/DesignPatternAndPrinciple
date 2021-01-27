using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    /// <summary>
    /// ConcreteCommand
    /// </summary>
    public class OpenFridgeDoorCommand : ICommand
    {
        public ElephantIntoFridge Fridge { get; private set; }

        public OpenFridgeDoorCommand(ElephantIntoFridge fridge)
        {
            Fridge = fridge;
        }
        public void Execute()
        {
            Fridge.OpenFridgeDoor();
        }
    }
}
