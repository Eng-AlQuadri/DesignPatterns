namespace Factory;

public class Program
{
    public static void Main(string[] args)
    {
        NotificationFactory factory = new SMSFactory();

        INotification notifier = factory.CreateNotification();

        notifier.Notify("Hello World!");
    }
}
