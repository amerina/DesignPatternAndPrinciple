using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterPattern
{
    public class Client
    {
        public void Interpret()
        {
            Context context = new Context("Hi, this is amerina here");
            TerminalExpression expression = new TerminalExpression();
            expression.Interpret(context);

            //NonterminalExpression
            IExpression expression1 = new NonterminalExpression(expression);
            expression1.Interpret(context);
        }
    }
}
