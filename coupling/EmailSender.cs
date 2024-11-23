using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcore.coupling
{
    public class EmailSender : INotificationService
    {

        public void SendNotification(string message)
        {
            System.Console.WriteLine($"Sending email: {message}");
        }
    }
}