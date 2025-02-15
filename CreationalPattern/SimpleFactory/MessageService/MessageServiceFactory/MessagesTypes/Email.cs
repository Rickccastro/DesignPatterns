namespace MessageServiceFactory.Messages;

public class Email : INotification
{
    public string Name { get; } = "Email";  

    public void SendMessage(string message)
    {
        Console.WriteLine($"[{Name}] Send Message: {message}");
    }

    public void SendNotification(string notification)
    {
        Console.WriteLine($"[{Name}] Notification: {notification}");
    }
}
