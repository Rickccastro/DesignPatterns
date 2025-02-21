namespace SingletonPattern.Singleton;

public sealed class SingletonPattern
{
    private static SingletonPattern instance = null;
    private SingletonPattern()
    {
        
    }

    public static SingletonPattern Instance
    {
        get
        {
            if (instance == null)
                instance = new SingletonPattern();  
            return instance;
        }
    }
}
