using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class Driver
    {
        public int Age { get;private set; }

        public Driver(int age)
        {
            this.Age = age;
        }

    }
}
