using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public class Employee
    {
        public string Name { get; }
        public string Dept { get; }

        public List<Employee> Subordinates { get; }

        public Employee(string name, string dept)
        {
            this.Name = name;
            this.Dept = dept;
            Subordinates = new List<Employee>();
        }

        public void Add(Employee employee)
        {
            Subordinates.Add(employee);
        }

        public void Remove(Employee employee)
        {
            Subordinates.Remove(employee);
        }


        public override string ToString()
        {
            return ("Employee :[ Name : " + Name + ", dept : " + Dept + " ]");
        }

        public void Display()
        {
            // Recursively display child nodes
            foreach (Employee component in Subordinates)
            {
                Console.WriteLine(component.ToString());
            }
        }
    }
}
