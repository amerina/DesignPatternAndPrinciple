using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern.Interface
{
    /// <summary>
    /// Visitor
    /// </summary>
    public interface IVisitor
    {
        void Visit(IElement element);
    }
}
