using Sensor_MonitoringExample.Observers;
using System.Diagnostics;

namespace Sensor_MonitoringExample.Subjects.ConcreteSubjects;

public class HumiditySensor : ISensor
{
    public string TypeSensor { get ; set; }

    public int HumidityValue { get ; set; }

    private List<IObserver> observers = new List<IObserver>();

    public HumiditySensor(string typeSensor,int humidityValue)
    {
        TypeSensor = typeSensor;
        HumidityValue = humidityValue;
    }

    public void NotifyObservers()
    {
        Console.WriteLine($"The {TypeSensor}");

        foreach (IObserver observer in observers)
        {
            observer.Update(HumidityValue);
        }
    }

    public void RegistryObservers(IObserver observer)
    {
        observers.Add(observer);    
    }

   public void RemoveObservers(IObserver observer)
    {
        observers.Remove(observer);
    }
}
