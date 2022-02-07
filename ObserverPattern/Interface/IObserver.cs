using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Interface
{
    /// <summary>
    /// 观察者接口,所有观察者实现这个接口
    /// </summary>
     public interface IObserver
    {
        void Update(string message);
    }
}
