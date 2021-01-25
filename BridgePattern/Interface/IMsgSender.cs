using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Interface
{
    public interface IMsgSender
    {
        void Send(string message);
    }

}
