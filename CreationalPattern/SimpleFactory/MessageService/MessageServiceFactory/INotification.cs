namespace MessageServiceFactory;

public interface INotification
{
    public string Name { get;} 
    public void SendMessage(string message);
    public void SendNotification(string notification);
}
