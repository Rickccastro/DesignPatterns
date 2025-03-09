using Sensor_MonitoringExample.Observers;

namespace Sensor_MonitoringExample.Subjects;
public interface ISensor
{
    public string TypeSensor { get; set; }
    public void NotifyObservers();
    public void RegistryObservers(IObserver observer);
    public void RemoveObservers(IObserver observer);
}
