using AdapterPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class People : IPeople
    {
        public void Speak()
        {
            Console.WriteLine("People speaking ...");
        }

        public void Walk()
        {
            Console.WriteLine("People walking ...");
        }
    }
}
