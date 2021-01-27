using System;

namespace ChainOfResponsibilityPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            HandlerChain chain = new HandlerChain();
            chain.AddHandler(new ConcreteHandlerOne());
            chain.AddHandler(new ConcreteHandlerTwo());
            chain.Handle("amerina");

            chain.Handle("my darling");
        }
    }
}
