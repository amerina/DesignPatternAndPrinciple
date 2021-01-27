using System;
using System.Collections.Generic;
using System.Text;

namespace MementoPattern
{
    /// <summary>
    /// 创建Memento并存储当前状态
    /// </summary>
    public class Originator
    {
        public string State { get; private set; }

        public void SetState(string state)
        {
            State = state;
        }

        public string GetState()
        {
            return State;
        }

        public Memento SaveStateToMemento()
        {
            return new Memento(State);
        }

        public void GetStateFromMemento(Memento memento)
        {
            State = memento.GetState();
        }
    }
}
