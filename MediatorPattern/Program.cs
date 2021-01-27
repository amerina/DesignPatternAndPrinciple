using System;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ConcreteMediator mediator = new ConcreteMediator();

            ConcreteColleagueOne colleagueOne = new ConcreteColleagueOne(mediator);
            ConcreteColleagueTwo colleagueTwo = new ConcreteColleagueTwo(mediator);

            mediator.ColleagueOne = colleagueOne;
            mediator.ColleagueTwo = colleagueTwo;

            colleagueOne.Send("Where are you, my darling?");
            colleagueTwo.Send("I'm here waiting for you.");

        }
    }
}
