using ObserverPattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    /// <summary>
    /// 观察者1
    /// </summary>
    public class ConcreteObserverOne : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine("ConcreteObserverOne received the message."+message);
        }
    }
}
