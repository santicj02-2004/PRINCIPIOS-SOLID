using System;
using System.Collections.Generic;
using System.Text;

namespace DIP
{
    public interface IMessageSender
    {
        void Send(string message);
    }
}
