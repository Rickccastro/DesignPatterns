using Sensor_MonitoringExample.Subjects;

namespace Sensor_MonitoringExample.Observers;

public class TemperatureSystem : IObserver
{
    public string NameSystem { get; set; }

    public TemperatureSystem(string nameSystem, ISensor sensor)
    {
        NameSystem = nameSystem;
        sensor.RegistryObservers(this);
    }

    public void Update(int temperatureValue)
    {
        Console.WriteLine($"The temperature test value is {temperatureValue}");
    }
}
