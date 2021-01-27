using StatePattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public class FridgeDoorClose : IFridgeState
    {
        public FridgeStateMachine StateMachine { get; }

        public FridgeDoorClose(FridgeStateMachine stateMachine)
        {
            StateMachine = stateMachine;
        }

        public void CloseFridgeDoor()
        {
            Console.WriteLine("If the fridge is closed, how can you do close it.");
        }

        public void OpenFridgeDoor()
        {
            Console.WriteLine("Now fridge is open.");
            StateMachine.FridgeState = new FridgeDoorOpen(StateMachine);
        }

        public void PutElephantIn()
        {
            Console.WriteLine("Fridge now is close, how can you put elephant in.");
        }
    }
}
