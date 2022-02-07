using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //创建具体主题实例
            ConcreteSubject subject = new ConcreteSubject();
            subject.RegisterObserver(new ConcreteObserverOne());
            subject.RegisterObserver(new ConcreteObserverTwo());

            //发布通知
            subject.NotifyObservers("Lili, here is a message from amerina.");
        }
    }
}
