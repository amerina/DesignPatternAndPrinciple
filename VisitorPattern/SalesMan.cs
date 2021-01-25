using System;
using System.Collections.Generic;
using System.Text;
using VisitorPattern.Interface;

namespace VisitorPattern
{
    /// <summary>
    /// ConcreteVisitor
    /// </summary>
    public class Salesman : IVisitor
    {
        public string Name { get; private set; }

        public Salesman(string name)
        {
            Name = name;
        }

        public void Visit(IElement element)
        {
            Student student = (Student)element;
            Console.WriteLine("Salesman: " + this.Name + " gave the gift to the student: " + student.Name);
        }
    }
}
