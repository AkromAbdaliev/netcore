using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcore.coupling
{
    public interface INotificationService
    {
        void SendNotification(string message);
    }
}