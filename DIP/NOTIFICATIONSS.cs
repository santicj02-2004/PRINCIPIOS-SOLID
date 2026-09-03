using System;
using System.Collections.Generic;
using System.Text;

namespace DIP
{
    public class NotificationService
    {
        private readonly IMessageSender _messageSender;
        public NotificationService(IMessageSender messageSender)
        {
            _messageSender = messageSender;
        }
        public void Notify(string message)
        {
            _messageSender.Send(message);
        }
    }
}
