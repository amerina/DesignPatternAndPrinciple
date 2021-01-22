using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Interface
{
    /// <summary>
    /// The Target defines the domain-specific interface used by the client code.
    /// </summary>
    public interface IPeople
    {
        void Speak();

        void Walk();
    }
}
