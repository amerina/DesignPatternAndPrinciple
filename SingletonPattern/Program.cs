using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var singleton = SingletonElephantIntoFridge.GetInstance();
            singleton.OpenFridgeDoor();
            singleton.PutElephantIn();
            singleton.CloseFridgeDoor();

        }
    }
}
