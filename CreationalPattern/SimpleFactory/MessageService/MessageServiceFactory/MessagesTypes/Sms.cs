namespace MessageServiceFactory.Messages;

public class Sms : INotification
{
    public string Name { get; } = "SMS";  

    public void SendMessage(string message)
    {
        Console.WriteLine($"[{Name}] Send Message: {message}");
    }

    public void SendNotification(string notification)
    {
        Console.WriteLine($"[{Name}] Notification: {notification}");
    }
}
