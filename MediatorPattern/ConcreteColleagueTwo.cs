using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern
{
    public class ConcreteColleagueTwo : Colleague
    {
        public ConcreteColleagueTwo(Mediator mediator):base(mediator)
        {

        }

        public override void Notify(string message)
        {
            Console.WriteLine($"Message to ConcreteColleagueTwo: {message}");
        }

    }
}
