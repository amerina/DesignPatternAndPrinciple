using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern
{
    public class ConcreteHandlerOne : Handler
    {
        protected override bool HandleRequest(string message)
        {
            bool handled = false;
            if (message.Contains("amerina"))
            {
                handled = true;
                Console.WriteLine("Dear, all around is you, my darling.");
            }
            return handled;
        }
    }
}
