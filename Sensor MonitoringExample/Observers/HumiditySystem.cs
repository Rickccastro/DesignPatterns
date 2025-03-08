using Sensor_MonitoringExample.Subjects;

namespace Sensor_MonitoringExample.Observers;

public class HumiditySystem : IObserver
{
    public string NameSystem { get; set; }

    public HumiditySystem(string nameSystem,ISensor sensor)
    {
        NameSystem = nameSystem;
        sensor.RegistryObservers(this);
    }
    public void Update(int valueHumidity)
    {
        Console.WriteLine($"The humidity test value is {valueHumidity}");
    }
}
