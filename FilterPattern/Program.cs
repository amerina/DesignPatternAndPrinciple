using FilterPattern.Criteria;
using FilterPattern.Interface;
using System;
using System.Collections.Generic;

namespace FilterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var persons = new List<Person> {
             new Person("Robert",GenderType.Male, MaritalStatus.Single),
             new Person("John", GenderType.Male, MaritalStatus.Married),
             new Person("Laura", GenderType.Female, MaritalStatus.Married),
             new Person("Diana", GenderType.Female, MaritalStatus.Single)
            };

            Console.WriteLine("Male:");
            IPersonCriteria male = new CriteriaMale();
            foreach (var person in male.MeetCriteria(persons))
            {
                Console.WriteLine(person.ToString());
            }

            Console.WriteLine("Female:");
            IPersonCriteria female = new CriteriaFemale();
            foreach (var person in female.MeetCriteria(persons))
            {
                Console.WriteLine(person.ToString());
            }

            Console.WriteLine("Single:");
            IPersonCriteria single = new CriteriaSingle();
            foreach (var person in single.MeetCriteria(persons))
            {
                Console.WriteLine(person.ToString());
            }

            Console.WriteLine("Single Males:");
            IPersonCriteria singleMale = new AndCriteria(single, male);
            foreach (var person in singleMale.MeetCriteria(persons))
            {
                Console.WriteLine(person.ToString());
            }

            Console.WriteLine("Single Or Females:");
            IPersonCriteria singleOrFemale = new OrCriteria(single, female);
            foreach (var person in singleOrFemale.MeetCriteria(persons))
            {
                Console.WriteLine(person.ToString());
            }
        }

    }
}
