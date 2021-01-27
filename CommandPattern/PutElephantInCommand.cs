using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class PutElephantInCommand : ICommand
    {
        public ElephantIntoFridge Fridge { get; private set; }

        public PutElephantInCommand(ElephantIntoFridge fridge)
        {
            Fridge = fridge;
        }
        public void Execute()
        {
            Fridge.PutElephantIn();
        }
    }
}
