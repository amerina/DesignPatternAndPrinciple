using FactoryPattern.SimpleFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class ShapeDecorator : IShape
    {
        protected IShape Shape{ get; private set; }

        public ShapeDecorator(IShape shape)
        {
            Shape = shape;
        }
        public virtual void Draw()
        {
            Shape.Draw();
        }
    }
}
