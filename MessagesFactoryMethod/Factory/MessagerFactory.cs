using MessagesFactoryMethod.Interfaces;

namespace MessagesFactoryMethod.Factory;

public abstract class MessagerFactory
{
    public abstract IMessager CreateMessager();
}

