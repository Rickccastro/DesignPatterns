using CarExampleBuilder.Engine;
using CarExampleBuilder.Models;

namespace CarExampleBuilder.Builder;

public class CarBuilder : IBuilder
{
    private Car car;

    public CarBuilder()
    {
        Reset();
    }

    public void Reset()
    {
        car = new Car();
    }

    public void SetSeats(int number)
    {
        car.Seats = number;
    }

    public void SetEngine(EngineCar engine)
    {
        car.Engine = engine;
    }

    public void SetTripComputer()
    {
        car.HasTripComputer = true;
    }

    public void SetGps()
    {
        car.HasGPS = true;
    }

    public Car GetResult()
    {
        return car;
    }
}
