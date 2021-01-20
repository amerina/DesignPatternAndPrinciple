using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.SimpleFactory
{
    public class Rectangle : IShape
    {
        public void Draw()
        {
            System.Console.WriteLine("Retangle draw.");
        }
    }
}
