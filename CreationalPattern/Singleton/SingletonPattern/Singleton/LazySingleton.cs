namespace SingletonPattern.Singleton;

public sealed class LazySingleton
{
    private readonly Lazy<LazySingleton> _lazySingleton = new Lazy<LazySingleton>(() => new LazySingleton());

    public static LazySingleton Instance {  get; } = new LazySingleton();   

    private LazySingleton()
    {

    } 

}
