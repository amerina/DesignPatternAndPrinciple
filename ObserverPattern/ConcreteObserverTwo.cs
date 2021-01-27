using ObserverPattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class ConcreteObserverTwo : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine("ConcreteObserverTwo received the message." + message);
        }
    }
}
