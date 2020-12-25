using Companies.Shared.Notifications.Models;
using System.Collections.Generic;

namespace Companies.Shared.Notifications.Interfaces
{
    public interface INotificationService
    {
        bool HasNotifications();

        IList<Notification> GetNotifications();

        void AddNotification(Notification notification);
        void AddNotifications(IEnumerable<Notification> notifications);
    }
}