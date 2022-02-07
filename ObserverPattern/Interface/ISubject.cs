using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Interface
{
    /// <summary>
    /// 主题接口,提供观察者注册可取消注册接口
    /// </summary>
    public interface ISubject
    {
        void RegisterObserver(IObserver observer); 
        void RemoveObserver(IObserver observer);
        void NotifyObservers(string message);
    }
}
