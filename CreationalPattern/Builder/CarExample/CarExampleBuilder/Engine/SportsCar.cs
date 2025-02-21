namespace CarExampleBuilder.Engine;

public class SportsCar : EngineCar
{
    public SportsCar()
    {
        Name = "Sport Engine";
    }
    public override void EngineSound()
    {
        Console.WriteLine("VRUMMM- SportsCar");
    }
}
