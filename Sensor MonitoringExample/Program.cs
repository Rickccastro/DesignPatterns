using Sensor_MonitoringExample.Observers;
using Sensor_MonitoringExample.Subjects.ConcreteSubjects;

namespace Sensor_MonitoringExample;

internal class Program
{
    static void Main(string[] args)
    {
        var humiditySensor = new HumiditySensor("HumiditySensor1",40);
        var pressureSensor = new PressureSensor("PressureSensor1", 60);
        var temperatureSensor = new PressureSensor("temperatureSensor1",28);

        var humiditySystem = new HumiditySystem("HumiditySystem1", humiditySensor);
        var pressureSystem = new PressureSystem("HumiditySystem1", pressureSensor);
        var temperatureSystem = new TemperatureSystem("temperatureSensor1", temperatureSensor);


        humiditySensor.NotifyObservers();

    }
}
