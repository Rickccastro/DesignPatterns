using PhoneObserver.Observer;

namespace PhoneObserver.Subject;
public interface ISubject
{
    public void NotifyObservers();
    public void RegistryObservers(IObserver observer);
    public void RemoveObservers(IObserver observer);
}
