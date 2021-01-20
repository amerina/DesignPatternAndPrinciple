using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.SimpleFactory;

namespace FactoryPattern.FactoryMethod
{
    public class SquareFactory : IFactory
    {
        public IShape Shape()
        {
            return new Square();
        }
    }
}
