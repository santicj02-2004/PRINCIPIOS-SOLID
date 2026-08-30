using System;
using System.Collections.Generic;
using System.Text;

namespace DIP
{
    public class SmsSender : IMessageSender
    {
        public void Send(string message)
        {
             Console.WriteLine("Sending SMS: " + message);
        }
    }
}
