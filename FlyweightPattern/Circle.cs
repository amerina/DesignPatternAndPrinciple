using FactoryPattern;
using FactoryPattern.SimpleFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    public class Circle : IShape
    {
        public ColorTypeEnum Color { get; private set; }

        public void SetColor(ColorTypeEnum color)
        {
            Color = color;
        }
        public void Draw()
        {
            Console.WriteLine("Draw "+ Color + " Circle");
        }
    }
}
