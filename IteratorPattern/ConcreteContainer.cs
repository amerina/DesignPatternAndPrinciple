using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    public class ConcreteContainer<T> : IContainer<T>
    {
        private List<T> Items = new List<T>();


        public int Count
        {
            get { return Items.Count; }
        }

        /// <summary>
        /// 索引器
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T this[int index]
        {
            get { return Items[index]; }
            set { Items.Insert(index, value); }
        }

        public void AddItem(T item)
        {
            Items.Add(item);
        }

        public IIterator<T> CreateIterator()
        {
            return new ConcreteIterator<T>(this);
        }
    }
}
