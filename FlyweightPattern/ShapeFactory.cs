using FactoryPattern.SimpleFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    public class ShapeFactory
    {
        private readonly Dictionary<ShapeTypeEnum, IShape> DicShape;

        public ShapeFactory()
        {
            DicShape = new Dictionary<ShapeTypeEnum, IShape>();
        }

        public IShape GetShape(ShapeTypeEnum shapeType)
        {
            DicShape.TryGetValue(shapeType, out var shape);

           
            if (shape == null)
            {
                switch (shapeType)
                {
                    case ShapeTypeEnum.CIRCLE:
                        shape = new Circle();
                        DicShape.Add(shapeType, shape);
                        Console.WriteLine("Circle is created.");
                        break;
                    case ShapeTypeEnum.SQUARE:
                        shape = new Square();
                        DicShape.Add(shapeType, shape);
                        Console.WriteLine("Square is created.");
                        break;
                case ShapeTypeEnum.UnKnown:
                    case ShapeTypeEnum.RECTANGLE:
                    default:
                        throw new ArgumentOutOfRangeException(nameof(shapeType), shapeType, null);
                }
            }
            return shape;
        }
    }
}
