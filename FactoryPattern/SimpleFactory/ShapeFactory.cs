using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.SimpleFactory
{
    /// <summary>
    /// 
    /// </summary>
    public class ShapeFactory
    {
        public IShape GetShape(ShapeTypeEnum shapeType)
        {
            //多态的应用。简单工厂模式是由一个工厂对象根据收到的消息决定要创建哪一个类的对象实例
            if (shapeType == ShapeTypeEnum.UnKnown)
            {
                return null;
            }
            if (shapeType == ShapeTypeEnum.CIRCLE)
            {
                return new Circle();
            }
            else if (shapeType == ShapeTypeEnum.RECTANGLE)
            {
                return new Rectangle();
            }
            else if (shapeType == ShapeTypeEnum.SQUARE)
            {
                return new Square();
            }
            return null;
        }


    }
}
