namespace Factory;

public class SMSFactory : NotificationFactory
{
    public override INotification CreateNotification()
    {
        return new SMSNotification();
    }
}