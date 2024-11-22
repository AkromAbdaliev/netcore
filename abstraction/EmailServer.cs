using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcore.abstraction
{
    public class EmailServer
    {
        public void SendEmail()
        { // applying abstraction
            Connect();
            Authanticate();
            System.Console.WriteLine("Sending email..");
            Disconnect();
        }

        private void Connect()
        {
            System.Console.WriteLine("Connecting to email server..");
        }

        private void Authanticate()
        {
            System.Console.WriteLine("Authenticating..");
        }

        private void Disconnect()
        {
            System.Console.WriteLine("Disconnecting from email server..");
        }
    }
}