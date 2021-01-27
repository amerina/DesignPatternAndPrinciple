using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern
{
    public class ConcreteHandlerTwo : Handler
    {
        protected override bool HandleRequest(string message)
        {
            bool handled = false;
            if (message.Contains("darling"))
            {
                handled = true;
                Console.WriteLine("Darling, I'll find you, no matter where are you.");
            }
            return handled;
        }
    }
}
