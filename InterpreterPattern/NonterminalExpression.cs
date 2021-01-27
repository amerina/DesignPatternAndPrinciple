using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterPattern
{
    public class NonterminalExpression : IExpression
    {
        public IExpression Expression { get; private set; }

        public NonterminalExpression(IExpression expression)
        {
            Expression = expression;
        }
        public void Interpret(Context context)
        {
            Console.WriteLine("This is not terminalExpression,but will call it.");
            Expression.Interpret(context);
        }
    }
}
