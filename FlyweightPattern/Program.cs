using FactoryPattern.SimpleFactory;
using System;

namespace FlyweightPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ShapeFactory shapeFactory = new ShapeFactory();

            Circle circle = (Circle)shapeFactory.GetShape(ShapeTypeEnum.CIRCLE);
            circle.SetColor(FactoryPattern.ColorTypeEnum.RED);
            circle.Draw();

            circle = (Circle)shapeFactory.GetShape(ShapeTypeEnum.CIRCLE);
            circle.SetColor(FactoryPattern.ColorTypeEnum.GREEN);
            circle.Draw();

            Square square = (Square)shapeFactory.GetShape(ShapeTypeEnum.SQUARE);
            square.SetColor(FactoryPattern.ColorTypeEnum.RED);
            square.Draw();

            square = (Square)shapeFactory.GetShape(ShapeTypeEnum.SQUARE);
            square.SetColor(FactoryPattern.ColorTypeEnum.GREEN);
            square.Draw();

        }
    }
}
