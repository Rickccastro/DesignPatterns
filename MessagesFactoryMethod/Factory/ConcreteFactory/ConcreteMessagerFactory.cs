using MessagesFactoryMethod.Interfaces;
using MessagesFactoryMethod.Products;

namespace MessagesFactoryMethod.Factory.ConcreteFactory;
  
    public class EmailSenderFactory : MessagerFactory
    {
        public override IMessager CreateMessager()
        {
            return new Email();
        }
    }

    public class WhatsAppSenderFactory : MessagerFactory
    {
        public override IMessager CreateMessager()
        {
            return new WhatsApp();
        }
    }

    public class SmsSenderFactory : MessagerFactory
    {
        public override IMessager CreateMessager()
        {
            return new Sms();
        }
    }
