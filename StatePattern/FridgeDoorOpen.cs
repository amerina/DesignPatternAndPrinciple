using StatePattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public class FridgeDoorOpen : IFridgeState
    {
        public FridgeStateMachine StateMachine { get; }

        public FridgeDoorOpen(FridgeStateMachine stateMachine)
        {
            StateMachine = stateMachine;
        }

        public void CloseFridgeDoor()
        {
            Console.WriteLine("Elephant is not in,you cannot close the fridge.");
        }

        public void OpenFridgeDoor()
        {
            Console.WriteLine("Fridge now is open,you need do nothing.");
        }

        public void PutElephantIn()
        {
            Console.WriteLine("Yes, you can put elephant in.");
            StateMachine.SetFridgeState(FridgeState.ElephantIn);
        }
    }
}
