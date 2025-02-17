using MessagesFactoryMethod.Interfaces;

namespace MessagesFactoryMethod.Products;

public class Sms : IMessager
{
    public string Name => "SMS";

    public void SendMessage(string message)
    {
        Console.WriteLine($"[{Name}] Send Message: {message}");
    }

    public void SendNotification(string notification)
    {
        Console.WriteLine($"[{Name}] Notification: {notification}");
    }
}
