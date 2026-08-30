using System;
using System.Collections.Generic;
using System.Text;

namespace DIP
{
    public class EmailSender : IMessageSender
    {
        public void Send(string message)
        {
            Console.WriteLine("Sending Email: " + message);
        }
    }
}
