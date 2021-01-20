using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.SimpleFactory;

namespace FactoryPattern
{
    /// <summary>
    /// 具体工厂:实现抽象工厂中的多个抽象方法，完成具体产品的创建
    /// </summary>
    public class ShapeFactory : AbstractFactory
    {
        public override IColor GetColor(ColorTypeEnum color)
        {
            throw new NotImplementedException();
        }

        public override IShape GetShape(ShapeTypeEnum shape)
        {
            switch (shape)
            {
                case ShapeTypeEnum.CIRCLE:
                    return new Circle();
                case ShapeTypeEnum.RECTANGLE:
                    return new Rectangle();
                case ShapeTypeEnum.SQUARE:
                    return new Square();
                case ShapeTypeEnum.UnKnown:
                default:
                    return null;
            }
        }
    }
}
