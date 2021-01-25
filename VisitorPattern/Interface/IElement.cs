using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern.Interface
{
    /// <summary>
    /// Element
    /// </summary>
    public interface IElement
    {
        void Accept(IVisitor visitor);
    }
}
