using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ConcreteSubject subject = new ConcreteSubject();
            subject.RegisterObserver(new ConcreteObserverOne());
            subject.RegisterObserver(new ConcreteObserverTwo());

            subject.NotifyObservers("Lili, here is a message from amerina.");
        }
    }
}
