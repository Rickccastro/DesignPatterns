using Sensor_MonitoringExample.Observers;

namespace Sensor_MonitoringExample.Subjects.ConcreteSubjects;

public class PressureSensor : ISensor
{ 
    public string TypeSensor { get; set; }

    public int  PressureValue { get; set; }

    private List<IObserver> observers = new List<IObserver>();


    public PressureSensor(string typeSensor, int pressureValue)
    {
        TypeSensor = typeSensor;
        PressureValue = pressureValue;
    }

    public void NotifyObservers()
    {
        Console.WriteLine($"The {TypeSensor}");

        foreach (IObserver observer in observers)
        {
            observer.Update(PressureValue);
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
