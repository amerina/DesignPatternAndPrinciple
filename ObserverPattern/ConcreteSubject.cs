using ObserverPattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    /// <summary>
    /// 具体的主题
    /// </summary>
    public class ConcreteSubject : ISubject
    {
        private List<IObserver> Observers = new List<IObserver>();
        public void NotifyObservers(string message)
        {
            Observers.ForEach(observer =>
            {
                //调用观察者接口方法
                observer.Update(message);
            });
        }

        /// <summary>
        /// 注册观察者
        /// </summary>
        /// <param name="observer"></param>
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
