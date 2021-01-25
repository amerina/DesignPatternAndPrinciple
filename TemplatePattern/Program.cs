using System;

namespace TemplatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ElephantIntoFridge elephant = new ManualPutElephant();
            elephant.PutElephantIntoFridge();
            Console.WriteLine();

            elephant = new AutoPutElephant();
            elephant.PutElephantIntoFridge();
        }
    }
}
