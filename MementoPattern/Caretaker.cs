using System;
using System.Collections.Generic;
using System.Text;

namespace MementoPattern
{
    public class Caretaker
    {
        private Stack<Memento> Mementos = new Stack<Memento>();

        public Memento GetMemento()
        {
            return Mementos.Pop();
        }
        public void AddMemento(Memento memento)
        {
            Mementos.Push(memento);
        }

    }
}
