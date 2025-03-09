using PhoneObserver.Observer;
using PhoneObserver.Subject;

namespace PhoneObserverExample;

internal class Program
{
    static void Main(string[] args)
    {
        var Iphone11 = new ConcreteSubject("Iphone11", 6000, "Out of stock");

        Console.WriteLine("Iphon11 - available:" + Iphone11.GetAvailable());

        var ricardo = new ConcreteObserver("Ricardo", Iphone11);
        var jonas = new ConcreteObserver("Jonas", Iphone11);
        var mary = new ConcreteObserver("Mary", Iphone11);

        Console.WriteLine("Please press any key to change the available status");
        Console.ReadLine();

        Iphone11.SetAvailable("Available");
    }
}
