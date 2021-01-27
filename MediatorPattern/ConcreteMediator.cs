using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern
{
    /// <summary>
    /// 中介者实现类
    /// </summary>
    public class ConcreteMediator : Mediator
    {
        public Colleague ColleagueOne { get; set; }
        public Colleague ColleagueTwo { get; set; }
        public override void Send(string message, Colleague colleague)
        {
            if (colleague == ColleagueOne)
            {
                ColleagueTwo.Notify(message);
            }
            else
            {
                ColleagueOne.Notify(message);
            }
        }
    }
}
