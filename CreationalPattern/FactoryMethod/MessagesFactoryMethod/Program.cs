using MessagesFactoryMethod.Factory.ConcreteFactory;

namespace MessagesFactoryMethod;

internal class Program
{
    static void Main(string[] args)
    {
        var wpp = new WhatsAppSenderFactory().CreateMessager();

        wpp.SendNotification("You receive one message");
        wpp.SendMessage("Hello");

        var email = new EmailSenderFactory().CreateMessager();

        email.SendNotification("You receive one message");
        email.SendMessage("Hello");

        var sms = new EmailSenderFactory().CreateMessager();

        sms.SendNotification("You receive one message");
        sms.SendMessage("Hello");

    }
}
