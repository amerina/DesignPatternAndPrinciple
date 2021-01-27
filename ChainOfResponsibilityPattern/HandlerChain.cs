using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern
{
    public class HandlerChain
    {
        private Handler handlerOne = null;
        private Handler handlerTwo = null;

        public void AddHandler(Handler handler)
        {
            handler.SetSuccessor(null);

            if (handlerOne == null)
            {
                handlerOne = handler;
                handlerTwo = handler;
                return;
            }

            handlerTwo.SetSuccessor(handler);
            handlerTwo = handler;
        }

        public void Handle(string message)
        {
            if (handlerOne != null)
            {
                handlerOne.Handle(message);
            }
        }
    }
}
