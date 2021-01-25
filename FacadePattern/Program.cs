using System;

namespace FacadePattern
{
    /// <summary>
    /// 聚合接口
    /// </summary>
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
