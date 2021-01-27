using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    public class ConcreteIterator<T> : IIterator<T>
    {
        private int Cursor;
        public ConcreteContainer<T> Container { get; private set; }

        public ConcreteIterator(ConcreteContainer<T> container)
        {
            Cursor = 0;
            Container = container;
        }
        public T CurrentItem()
        {
            if (Cursor >= Container.Count)
            {
                return default(T);
            }
            return Container[Cursor];
        }

        public bool HasNext()
        {
            return Cursor != Container.Count;
        }

        public void Next()
        {
            Cursor++;
        }
    }
}
