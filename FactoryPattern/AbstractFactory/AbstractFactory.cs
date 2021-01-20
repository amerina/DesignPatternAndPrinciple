using FactoryPattern.SimpleFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    /// <summary>
    /// 抽象工厂:提供了创建产品的接口，它包含多个创建产品的方法，可以创建多个不同类型的产品
    /// </summary>
    public abstract class AbstractFactory
    {
        public abstract IColor GetColor(ColorTypeEnum color);
        public abstract IShape GetShape(ShapeTypeEnum shape);
    }
}
