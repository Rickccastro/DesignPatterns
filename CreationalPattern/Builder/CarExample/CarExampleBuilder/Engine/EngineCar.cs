namespace CarExampleBuilder.Engine;

public abstract class EngineCar
{
    public  string Name { get; set; } = "Generic Engine";
    public abstract void EngineSound();
}
