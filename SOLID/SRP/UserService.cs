using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcore.SOLID.SRP
{
    public class UserService
    {
        public void Register(User user)
        {
            // User registering logic...

            // Send email
            EmailSender emailSender = new EmailSender();
            emailSender.SendEmail(user.Email, "Welcome to our platform");
        }
    }
}