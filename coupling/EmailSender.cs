using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcore.coupling
{
    public class EmailSender
    {
        public void SendEmail(string email)
        {
            System.Console.WriteLine($"Sending email: {email}");
        }
    }
}