using System;
using System.Collections.Generic;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ConcreteContainer<string> container = new ConcreteContainer<string>();

            container[0] = "Amerina";
            container.AddItem("Darling");

           var iterator = container.CreateIterator();
            var item = iterator.CurrentItem();
            while (item != null)
            {
                Console.WriteLine(item);
                if (iterator.HasNext())
                {
                    iterator.Next();
                    item = iterator.CurrentItem();
                }
            }

        }
    }
}
