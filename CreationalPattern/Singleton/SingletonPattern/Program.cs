namespace SingletonPattern;

internal class Program
{
    static void Main(string[] args)
    {
        var singletonPattern1 = Singleton.SingletonPattern.Instance;
        var singletonPattern2 = Singleton.SingletonPattern.Instance;


        var singletonLazyPattern1 = Singleton.LazySingleton.Instance;
        var singletonLazyPattern2 = Singleton.LazySingleton.Instance;

        if(singletonPattern1 == singletonPattern2)
        {
            Console.WriteLine("Singleton works, both variables contain the same instance.");
        }

        if(singletonLazyPattern1 == singletonLazyPattern2)
        {
            Console.WriteLine("Lazy Singleton works, both variables contain the same instance.");
        }
    }
}
