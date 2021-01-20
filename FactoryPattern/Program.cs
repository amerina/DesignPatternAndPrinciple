using FactoryPattern.FactoryMethod;
using FactoryPattern.SimpleFactory;
using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            #region Simple Factory

            ShapeFactory shapeFactory = new ShapeFactory();//new 一个工厂对象

            //获取 Circle 的对象，并调用它的 draw 方法
            IShape shape1 = shapeFactory.GetShape(ShapeTypeEnum.CIRCLE);
            //调用 Circle 的 draw 方法
            shape1.Draw();

            //获取 Rectangle 的对象，并调用它的 draw 方法
            IShape shape2 = shapeFactory.GetShape(ShapeTypeEnum.RECTANGLE);
            //调用 Rectangle 的 draw 方法
            shape2.Draw();

            //获取 Square 的对象，并调用它的 draw 方法
            IShape shape3 = shapeFactory.GetShape(ShapeTypeEnum.SQUARE);
            //调用 Square 的 draw 方法
            shape3.Draw();

            #endregion

            #region Factory Method

            IFactory factory = new CircleFactory();
            IShape shape = factory.Shape();
            shape.Draw();

            #endregion

            #region AbstractFactory

            //获取形状工厂
            AbstractFactory shapeFactory1 = FactoryProducer.GetFactory("SHAPE");

            //获取形状为 Circle 的对象
            IShape shape4 = shapeFactory1.GetShape(ShapeTypeEnum.CIRCLE);

            //调用 Circle 的 draw 方法
            shape4.Draw();

            //获取形状为 Rectangle 的对象
            IShape shape5 = shapeFactory.GetShape(ShapeTypeEnum.RECTANGLE);

            //调用 Rectangle 的 draw 方法
            shape5.Draw();
          

            //获取颜色工厂
            AbstractFactory colorFactory = FactoryProducer.GetFactory("COLOR");

            //获取颜色为 Red 的对象
            IColor color1 = colorFactory.GetColor(ColorTypeEnum.RED);

            //调用 Red 的 fill 方法
            color1.fill();

            #endregion
        }
    }
}
