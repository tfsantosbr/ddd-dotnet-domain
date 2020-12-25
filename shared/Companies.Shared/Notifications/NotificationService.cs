using Companies.Shared.Notifications.Interfaces;
using Companies.Shared.Notifications.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Companies.Shared.Notifications
{
    public class NotificationService : INotificationService, IDisposable
    {
        private readonly List<Notification> _notifications = new List<Notification>();

        public void Dispose()
        {
            _notifications.Clear();
        }

        public IList<Notification> GetNotifications()
        {
            return _notifications;
        }

        public void AddNotification(Notification notification)
        {
            _notifications.Add(notification);
        }

        public bool HasNotifications()
        {
            return _notifications.Any();
        }

        public void AddNotifications(IEnumerable<Notification> notifications)
        {
            _notifications.AddRange(notifications);
        }
    }
}