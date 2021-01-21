using FactoryPattern.SimpleFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectPattern
{
    /// <summary>
    /// 根据新添加的OthersShape重写SimpleFactory中的ShapeFactory
    /// </summary>
    public class ShapeFactory
    {
        public IShape GetShape(ShapeTypeEnum shapeType)
        {
            switch (shapeType)
            {
                case ShapeTypeEnum.CIRCLE:
                    return new Circle();
                case ShapeTypeEnum.RECTANGLE:
                    return new Rectangle();
                case ShapeTypeEnum.SQUARE:
                    return new Square();
                case ShapeTypeEnum.UnKnown:
                default:
                    //Difference is here
                    return new OthersShape();
            }

        }
    }
}
