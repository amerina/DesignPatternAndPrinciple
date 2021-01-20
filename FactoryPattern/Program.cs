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


        }
    }
}
