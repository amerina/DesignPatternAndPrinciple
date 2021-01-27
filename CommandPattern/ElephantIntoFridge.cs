using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    /// <summary>
    /// Receiver
    /// </summary>
    public class ElephantIntoFridge
    {
        public void OpenFridgeDoor()
        {
            Console.WriteLine("Fridge Door now is open.");
        }

        public void PutElephantIn()
        {
            Console.WriteLine("Elephant now is in Fridge.");
        }

        public void CloseFridgeDoor()
        {
            Console.WriteLine("Fridge Door now is close.");
        }
    }
}
