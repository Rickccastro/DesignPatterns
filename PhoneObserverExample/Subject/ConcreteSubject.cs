
using PhoneObserver.Observer;

namespace PhoneObserver.Subject;

public class ConcreteSubject : ISubject
{
    private List<IObserver> observers = new List<IObserver>();

    public ConcreteSubject(string product, int price,string available)
    {
        Available = available;
        Price = price;
        Product = product;
    }

    public string Available { get; set; }
    public int Price { get; set; }
    public string Product { get; set; }


    public void NotifyObservers()
    {
        Console.WriteLine($"Product:{Product},Price {Price}");

        foreach (IObserver observer in observers )
        {
            observer.Update(Available);
        }
    }

    public void RegistryObservers(IObserver observer)
    {
        Console.WriteLine("Observer added:" + ((ConcreteObserver)observer));
        observers.Add(observer);    
    }

    public void RemoveObservers(IObserver observer)
    {
        throw new NotImplementedException();
    }

    public string GetAvailable()
    {
        return Available;
    }
    public void SetAvailable(string available)
    {
        this.Available = available;
        Console.WriteLine("The availability has changed from Out of stock to Available.");
        NotifyObservers();
    }
    public void AddObservers(IObserver observer)
    {
        observers.Add(observer);
    }
}
