using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise_exam
{
    public interface INotificationObserver
    {
        void Update(string message);
    }

    public class EmailNotifier : INotificationObserver
    {
        public void Update(string message)
        {
            Console.WriteLine($"Email Notification: {message}");
        }
    }

    public class SMSNotifier : INotificationObserver
    {
        public void Update(string message)
        {
            Console.WriteLine($"SMS Notification: {message}");
        }
    }
    public class NotificationService
    {
        private List<INotificationObserver> _observers = new List<INotificationObserver>();

        public void Subscribe(INotificationObserver observer)
        {
            _observers.Add(observer);
        }
        public void Unsubscribe(INotificationObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify(string message)
        {
            foreach (var observer in _observers)
            {
                observer.Update(message);
            }
        }
    }

}
