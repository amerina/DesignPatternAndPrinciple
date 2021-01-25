using FactoryPattern.SimpleFactory;
using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IShape circle = new Circle();
            circle.Draw();

            ShapeDecorator shapeDecorator = new ColorShapeDecorator(circle);
            shapeDecorator.Draw();

        }
    }
}
