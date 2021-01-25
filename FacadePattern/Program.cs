using System;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ShapeFacade shapeFacade = new ShapeFacade();
            shapeFacade.DrawCircle();
            shapeFacade.DrawRectangle();
            shapeFacade.DrawSquare();
        }
    }
}
