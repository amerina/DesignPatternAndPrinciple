using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterPattern
{
    public class Context
    {
        public string Output { get; set; }
        public Context(string output)
        {
            Output = output;
        }

    }
}
