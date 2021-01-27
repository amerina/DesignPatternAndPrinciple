using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Interface
{
     public interface IObserver
    {
        void Update(string message);
    }
}
