namespace MessagesFactoryMethod.Interfaces;
public interface IMessager
{
    public void SendMessage(string message);
    public string Name { get; }
    public void SendNotification(string notification);
}
