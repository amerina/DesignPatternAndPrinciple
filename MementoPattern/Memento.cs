using System;
using System.Collections.Generic;
using System.Text;

namespace MementoPattern
{
    /// <summary>
    /// 要被恢复的对象的状态
    /// </summary>
    public class Memento
    {
        public string State { get; private set; }

        public Memento(string state)
        {
            State = state;
        }

        public string GetState()
        {
            return State;
        }
    }
}
