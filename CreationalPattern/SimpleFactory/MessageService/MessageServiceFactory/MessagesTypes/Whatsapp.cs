namespace MessageServiceFactory.Messages;

public class Whatsapp : INotification
{
    public string Name { get; } = "WhatsApp"; 

    public void SendMessage(string message)
    {
        Console.WriteLine($"[{Name}] Send Message: {message}");
    }

    public void SendNotification(string notification)
    {
        Console.WriteLine($"[{Name}] Notification: {notification}");
    }
}
