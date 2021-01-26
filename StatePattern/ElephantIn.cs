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
            Console.WriteLine("Elephant is in,you can close the fridge.");
            StateMachine.SetFridgeState(FridgeState.FridgeDoorClose);
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
