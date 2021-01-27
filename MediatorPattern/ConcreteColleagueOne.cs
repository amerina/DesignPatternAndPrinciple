using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern
{
    public class ConcreteColleagueOne : Colleague
    {
        public ConcreteColleagueOne(Mediator mediator):base(mediator)
        {
            
        }

        public override void Notify(string message)
        {
            Console.WriteLine($"Message to ConcreteColleagueOne: {message}");
        }

    }
}
