using System;
using System.Collections.Generic;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            NormalNotification notification = new NormalNotification(new EmailMsgSender(new List<string> { "wyzandi@gmail.com" }));
            notification.Notify(" Here is a person read your BridgePattern code.");
        }
    }
}
