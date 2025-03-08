using Sensor_MonitoringExample.Observers;

namespace Sensor_MonitoringExample.Subjects.ConcreteSubjects;

public class TemperatureSensor : ISensor
{
    public string TypeSensor { get; set; }
    public int TemperatureValue { get; set; }

    private List<IObserver> observers = new List<IObserver>();

    public TemperatureSensor(string typeSensor, int temperatureValue)
    {
        TypeSensor = typeSensor;
        TemperatureValue = temperatureValue;
    }

    public void NotifyObservers()
    {
        Console.WriteLine($"The {TypeSensor}");

        foreach (IObserver observer in observers)
        {
            observer.Update(TemperatureValue);
        }
    }

    void ISensor.RegistryObservers(IObserver observer)
    {
        observers.Add(observer);
    }

    void ISensor.RemoveObservers(IObserver observer)
    {
        observers.Remove(observer);
    }
}
