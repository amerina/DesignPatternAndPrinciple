using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Interface
{
    public interface ISortStrategy
    {
        void Sort(List<string> list);
    }
}
