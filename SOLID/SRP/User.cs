using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcore.SOLID.SRP
{
    public class User
    {
        public string UserName { get; set; }
        public string Email { get; set; }

        public void Register()
        {
            // User registering logic...

            // Send email
            EmailSender emailSender = new EmailSender();
            emailSender.SendEmail(Email, "Welcome to our platform");
        }
    }
}