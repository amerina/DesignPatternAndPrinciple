using System;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Employee CEO = new Employee("John", "CEO");

            Employee headSales = new Employee("Robert", "Head Sales");
          
            Employee headMarketing = new Employee("Michel", "Head Marketing");

            Employee clerk1 = new Employee("Laura", "Marketing");
            Employee clerk2 = new Employee("Bob", "Marketing");

            Employee salesExecutive1 = new Employee("Richard", "Sales");
            Employee salesExecutive2 = new Employee("Rob", "Sales");

            CEO.Add(headSales);
            CEO.Add(headMarketing);

            headSales.Add(salesExecutive1);
            headSales.Add(salesExecutive2);

            headMarketing.Add(clerk1);
            headMarketing.Add(clerk2);

            Console.WriteLine(CEO.ToString());
            CEO.Display();
            Console.WriteLine("**************");


            Console.WriteLine(headSales.ToString());
            headSales.Display();
            Console.WriteLine("**************");

            Console.WriteLine(headMarketing.ToString());
            headMarketing.Display();
        }
    }
}
