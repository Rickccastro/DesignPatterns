using MessagesFactoryMethod.Interfaces;

namespace MessagesFactoryMethod.Products;

public class WhatsApp : IMessager
{
    public string Name => "WhatsApp";

    public void SendMessage(string message)
    {
        Console.WriteLine($"[{Name}] Send Message: {message}");
    }

    public void SendNotification(string notification)
    {
        Console.WriteLine($"[{Name}] Notification: {notification}");
    }
}
