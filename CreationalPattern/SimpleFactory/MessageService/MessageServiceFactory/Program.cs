namespace MessageServiceFactory;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose your kind of message");
        var messagerType = Console.ReadLine();   

        var factoryMessager = MessagerSimpleFactory.MessagerSimpleFactory.CreateMessager(Convert.ToChar(messagerType!));

        factoryMessager.SendNotification("You receive a message from Rick");
        factoryMessager.SendMessage("Hello my name is Rickccastro");   
    }
}
