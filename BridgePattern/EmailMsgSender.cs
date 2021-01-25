using BridgePattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class EmailMsgSender : IMsgSender
    {
        private List<string> EmailAddress;

        public EmailMsgSender(List<string> emailAddress)
        {
            EmailAddress = emailAddress;
        }
        public void Send(string message)
        {
            EmailAddress.ForEach(email =>
            {
                Console.WriteLine(email + message);
            });
        }
    }
}
