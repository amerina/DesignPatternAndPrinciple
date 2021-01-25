﻿using BridgePattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class SevereNotification : Notification
    {
        public SevereNotification(IMsgSender msgSender):base(msgSender)
        {
            this.MsgSender = msgSender;
        }
        public override void Notify(string message)
        {
            MsgSender.Send(message);
        }
    }
}
