namespace CarExampleBuilder.Engine;

public class RegularEngine : EngineCar
{
    public RegularEngine()
    {
        Name = "Regular Engine";
    }
    public override void EngineSound()
    {
        Console.WriteLine("vrumm- Regular Engine");
    }
}
