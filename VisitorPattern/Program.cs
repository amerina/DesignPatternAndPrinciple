using System;

namespace VisitorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //
            School school = new School();
            school.PerformOperation(new Teacher("Amerina"));
            Console.WriteLine();

            school.PerformOperation(new Salesman("Jack"));
            Console.WriteLine();

        }
    }
}
