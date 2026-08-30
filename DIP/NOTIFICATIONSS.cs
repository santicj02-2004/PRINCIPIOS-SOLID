using System;
using System.Collections.Generic;
using System.Text;

namespace DIP
{
    public class NotificationService
    {
        private readonly IMessageSender _messageSender;//declara un campo privado y de solo lectura dentro de una clase
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
