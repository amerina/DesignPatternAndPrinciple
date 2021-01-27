using StatePattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public class FridgeStateMachine : IFridgeState
    {
        public IFridgeState FridgeState { get; set; }

        public FridgeStateMachine()
        {
            FridgeState = new FridgeDoorClose(this);
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
