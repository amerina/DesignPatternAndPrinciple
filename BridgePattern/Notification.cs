using BridgePattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public abstract class Notification
    {
        protected IMsgSender MsgSender;

        public Notification(IMsgSender msgSender)
        {
            this.MsgSender = msgSender;
        }
        public abstract void Notify(string message);

    }
}
