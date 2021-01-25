using System;
using System.Collections.Generic;
using System.Text;
using VisitorPattern.Interface;

namespace VisitorPattern
{
    /// <summary>
    /// ConcreteVisitor
    /// </summary>
    public class Teacher : IVisitor
    {
        public string Name { get; set; }

        public Teacher(string name)
        {
            Name = name;
        }

        public void Visit(IElement element)
        {
            Student student = (Student)element;
            Console.WriteLine("Teacher: " + this.Name + " checkup of the student: " + student.Name);
        }
    }
}
