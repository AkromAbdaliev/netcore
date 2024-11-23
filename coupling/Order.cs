using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcore.coupling
{
    public class Order
    {
        private readonly INotificationService notificationService;
        public Order(INotificationService notificationService)
        {
            this.notificationService = notificationService;
        }
        public void PlaceOrder()
        {
            // Place order loogic...
            // EmailSender email = new EmailSender();
            notificationService.SendNotification("Order placed successfully");
        }
    }
}