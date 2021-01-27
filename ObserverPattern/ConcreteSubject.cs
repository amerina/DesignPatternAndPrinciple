using ObserverPattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class ConcreteSubject : ISubject
    {
        private List<IObserver> Observers = new List<IObserver>();
        public void NotifyObservers(string message)
        {
            Observers.ForEach(observer =>
            {
                observer.Update(message);
            });
        }

        public void RegisterObserver(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            Observers.Add(observer);
        }
    }
}
