using MessageServiceFactory.Messages;

namespace MessageServiceFactory.MessagerSimpleFactory;

public class MessagerSimpleFactory
{
    public static INotification CreateMessager(char messagerType)
    {
        INotification messager;

        switch (messagerType)
        {
            case 'W':
                messager = new Whatsapp();
                break;
            case 'E':
                messager = new Email();
                break;
            case 'S':
                messager = new Sms();
                break;
            default:
                throw new ApplicationException($"The '{messagerType}' was not created");
        }
        return messager;
    }
}
