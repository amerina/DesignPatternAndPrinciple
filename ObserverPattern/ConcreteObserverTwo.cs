using ObserverPattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    /// <summary>
    /// 观察者2
    /// </summary>
    public class ConcreteObserverTwo : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine("ConcreteObserverTwo received the message." + message);
        }
    }
}
