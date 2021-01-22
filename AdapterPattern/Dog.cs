using AdapterPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class Dog : IDog
    {
        public void Bow()
        {
            Console.WriteLine("Dog bowing...");
        }

        public void Crawl()
        {
            Console.WriteLine("Dog crawing...");
        }
    }
}
