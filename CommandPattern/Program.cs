using System;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ElephantIntoFridge fridge = new ElephantIntoFridge();

            ICommand command = new OpenFridgeDoorCommand(fridge);

            Invoker invoker = new Invoker();
            invoker.SetCommand(command);
            invoker.ExecuteCommand();

            //
            command = new PutElephantInCommand(fridge);
            invoker.SetCommand(command);
            invoker.ExecuteCommand();

            //
            command = new CloseFridgeDoorCommand(fridge);
            invoker.SetCommand(command);
            invoker.ExecuteCommand();

        }
    }
}
