using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern.Interface
{
    /// <summary>
    /// Creating the State interface
    /// </summary>
    public interface IFridgeState
    {
        void OpenFridgeDoor();
        void PutElephantIn();
        void CloseFridgeDoor();
    }
}
