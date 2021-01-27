using ObserverPattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class ConcreteObserverOne : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine("ConcreteObserverOne received the message."+message);
        }
    }
}
