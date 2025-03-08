using Sensor_MonitoringExample.Subjects;

namespace Sensor_MonitoringExample.Observers;

public class PressureSystem : IObserver
{
    public string NameSystem { get ; set; }

    public PressureSystem(string nameSystem,ISensor sensor)
    {
        NameSystem = nameSystem;
        sensor.RegistryObservers(this);      
    }
    public void Update(int pressureValue)
    {
        Console.WriteLine($"The pressure test value is {pressureValue}");
    }
}
