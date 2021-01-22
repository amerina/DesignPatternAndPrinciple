using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern.Interface
{
    public interface IPrototype : ICloneable
    {
        object DeepClone();
    }
}
