using System;
using System.Collections.Generic;
using System.Text;

namespace TemplatePattern
{
    public class ManualPutElephant : ElephantIntoFridge
    {
        public override void CloseFridgeDoor()
        {
            Console.WriteLine("People close fridge door.");
        }

        public override void OpenFridgeDoor()
        {
            Console.WriteLine("People open fridge door.");
        }

        public override void PutElephantIn()
        {
            Console.WriteLine("People put the elephant in.");
        }
    }
}
