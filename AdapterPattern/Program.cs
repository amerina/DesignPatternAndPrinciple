using AdapterPattern.Interface;
using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IDog adaptee = new Dog();
            IPeople target = new DogAdapter(adaptee);

            Console.WriteLine("Adaptee interface is incompatible with the client.");
            Console.WriteLine("But with adapter client can call it's method.");

            target.Speak();
            target.Walk();
        }
    }
}
