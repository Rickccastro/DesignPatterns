using PhoneObserver.Subject;

namespace PhoneObserver.Observer;

public class ConcreteObserver : IObserver
{
    public string Users { get; set; }

    public ConcreteObserver(string name, ISubject subject)
    {
        Users = name;
        subject.RegistryObservers(this);
    }

    public void Update(string available)
    {
        Console.WriteLine($"Hello {Users}, the product that you desire is now {available} in your website");
    }
}
