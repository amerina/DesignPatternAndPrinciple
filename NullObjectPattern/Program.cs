using FactoryPattern.SimpleFactory;
using System;

namespace NullObjectPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ShapeFactory shapeFactory = new ShapeFactory();//new 一个工厂对象

            //获取 Circle 的对象，并调用它的 draw 方法
            IShape shape1 = shapeFactory.GetShape(ShapeTypeEnum.CIRCLE);
            //调用 Circle 的 draw 方法
            shape1.Draw();

            //获取 Rectangle 的对象，并调用它的 draw 方法
            IShape shape2 = shapeFactory.GetShape(ShapeTypeEnum.RECTANGLE);
            //调用 Rectangle 的 draw 方法
            shape2.Draw();

            //获取 Null Object 对象，并调用它的 draw 方法
            IShape shape3 = shapeFactory.GetShape(ShapeTypeEnum.UnKnown);
            //调用 Null Object 的 draw 方法
            shape3.Draw();
        }
    }
}
