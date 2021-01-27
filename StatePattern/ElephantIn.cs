using StatePattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public class ElephantIn : IFridgeState
    {
        public FridgeStateMachine StateMachine { get; }

        public ElephantIn(FridgeStateMachine stateMachine)
        {
            StateMachine = stateMachine;
        }
        public void CloseFridgeDoor()
        {
            Console.WriteLine("Elephant is in,and the fridge is close.");
            StateMachine.FridgeState = new FridgeDoorClose(StateMachine);
        }

        public void OpenFridgeDoor()
        {
            Console.WriteLine("Fridge door now is open, you cannot do this.");
        }

        public void PutElephantIn()
        {
            Console.WriteLine("Elephant is in, only one elephant you have.");
        }
    }
}
