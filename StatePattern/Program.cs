using System;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            FridgeStateMachine stateMachine = new FridgeStateMachine();
            stateMachine.OpenFridgeDoor();

            stateMachine.PutElephantIn();

            stateMachine.CloseFridgeDoor();
        }
    }
}
