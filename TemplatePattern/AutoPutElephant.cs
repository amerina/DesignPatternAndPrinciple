using System;
using System.Collections.Generic;
using System.Text;

namespace TemplatePattern
{
    public class AutoPutElephant : ElephantIntoFridge
    {
        public override void CloseFridgeDoor()
        {
            Console.WriteLine("Elephant close the fridge door.");
        }

        public override void OpenFridgeDoor()
        {
            Console.WriteLine("Elephant open the fridge door.");
        }

        public override void PutElephantIn()
        {
            Console.WriteLine("Elephant goes into the fridge.");
        }
    }
}
