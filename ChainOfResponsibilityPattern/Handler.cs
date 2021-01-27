using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern
{
    public abstract class Handler
    {
        protected Handler Successor = null;

        public void SetSuccessor(Handler successor)
        {
            Successor = successor;
        }

        public void Handle(string message)
        {
            bool handled = HandleRequest(message);
            if (Successor != null && !handled)
            {
                Successor.Handle(message);
            }
        }

        protected abstract bool HandleRequest(string message);
    }
}
