using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    public interface IIterator<T>
    {
        bool HasNext();
        T CurrentItem();
        void Next();

    }
}
