using StatePattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public class FridgeStateMachine : IFridgeState
    {
        public IFridgeState FridgeState { get; set; }
        public FridgeState CurrentFridgeState { get ;private set; }

        public FridgeStateMachine(IFridgeState fridgeState)
        {
            FridgeState = fridgeState;
        }

        public void OpenFridgeDoor()
        {
            FridgeState.OpenFridgeDoor();
        }

        public void PutElephantIn()
        {
            FridgeState.PutElephantIn();
        }

        public void CloseFridgeDoor()
        {
            FridgeState.CloseFridgeDoor();
        }

        public void SetFridgeState(FridgeState fridgeState)
        {
            CurrentFridgeState = fridgeState;
        }

        public FridgeState GetCurrentState()
        {
            return CurrentFridgeState;
        }

    }

    public enum FridgeState
    {
        /// <summary>
        /// 
        /// </summary>
        FridgeDoorOpen = 1,

        /// <summary>
        /// 
        /// </summary>
        ElephantIn = 2,

        /// <summary>
        /// 
        /// </summary>
        FridgeDoorClose = 3
    }
}
