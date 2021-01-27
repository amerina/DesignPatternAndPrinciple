using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterPattern
{
    public interface IExpression
    {
        void Interpret(Context context);
    }
}
