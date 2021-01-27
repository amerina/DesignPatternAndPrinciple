using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterPattern
{
    public class TerminalExpression : IExpression
    {
        public void Interpret(Context context)
        {
            Console.WriteLine("TerminalExpression handle {0}.", context.Output);

            if (context.Output.Contains("amerina"))
            {
                context.Output += "Amerina has some ex-girlfriend";
                Console.WriteLine(context.Output);
            }
            
        }
    }
}
