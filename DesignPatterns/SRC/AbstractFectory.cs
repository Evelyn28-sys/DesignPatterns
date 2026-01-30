namespace DesignPatterns.SRC
{
    public interface INotification
    {
        void Send(string message);
    }
    public class EmailNotification : INotification
    {
        public void Send(string message) => Console.WriteLine($"Email: {message}");
    }
    public class SmsNotification : INotification
    {
        public void Send(string message) => Console.WriteLine($"SMS: {message}");
    }
    public interface INotificationFactory
    {
        INotification CreateNotification();
    }
    public class EmailNotificationFactory : INotificationFactory
    {
        public INotification CreateNotification() => new EmailNotification();
    }
    public class SmsNotificationFactory : INotificationFactory
    {
        public INotification CreateNotification() => new SmsNotification();
    }

    public static class AbstractFactoryDemo
    {
        public static void Run()
        {
            INotificationFactory notifFactory = new EmailNotificationFactory();
            var notification = notifFactory.CreateNotification();
            notification.Send("Bem-vindo ao sistema!");
        }
    }
}
