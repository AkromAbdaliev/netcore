using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcore.coupling
{
    public class Order
    {
        public void PlaceOrder()
        {
            // Place order loogic...
            EmailSender email = new EmailSender();
            email.SendEmail("Order placed successfully");
        }
    }
}