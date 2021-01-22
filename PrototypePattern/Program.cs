using FilterPattern;
using System;
using System.Collections.Generic;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var personMySelf = new Person();
            personMySelf.Name = "Amerina";
            personMySelf.Gender = GenderType.Male;
            personMySelf.MaritalStatus = MaritalStatus.Married;
            personMySelf.ExFriend.Name = "Scarlett Johansson";

            var CloneMan = (Person)personMySelf.Clone();
            Console.WriteLine("Clone Man: " + CloneMan.ToString());

            //CloneMan is a shallow copy,if you edit ex-friend,personMySelf will also change.
            CloneMan.ExFriend.Name = "All Ex-friend is going, only left my wife,That's sad.";
         
            Console.WriteLine("Clone Man: " + CloneMan.ToString());
            Console.WriteLine("Person My Self: " + personMySelf.ToString());

            Console.WriteLine();

            //Deep Clone
            personMySelf.ExFriend.Name = "Scarlett Johansson";
           
            var DeepCloneMan = (Person)personMySelf.DeepClone();
            Console.WriteLine("Deep Clone Man: " + DeepCloneMan.ToString());

            DeepCloneMan.ExFriend.Name = "All Ex-friend is going, only left my wife,That's sad.";
            Console.WriteLine("Deep Clone Man: " + DeepCloneMan.ToString());

            Console.WriteLine("Person My Self: " + personMySelf.ToString());


        }
    }


}
