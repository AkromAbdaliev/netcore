using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcore.SOLID.SRP
{
    public class EmailSender
    {
        public void SendEmail(string email, string message)
        {
            System.Console.WriteLine($"Sending email to {email}: {message}");
        }
    }
}