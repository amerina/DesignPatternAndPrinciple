using BridgePattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class PhoneMsgSender : IMsgSender
    {
        private List<string> Telephones;

        public PhoneMsgSender(List<string> telephones)
        {
            this.Telephones = telephones;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        public void Send(string message)
        {
            Telephones.ForEach(phone =>
            {
                Console.WriteLine(phone + message);
            });
        }
    }

}
