using FactoryPattern.SimpleFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class ColorShapeDecorator : ShapeDecorator
    {
        public ColorShapeDecorator(IShape shape) : base(shape)
        {

        }

        public override void Draw()
        {
            Shape.Draw();
            Console.WriteLine("ColorShapeDecorator add function.");
        }
    }
}
