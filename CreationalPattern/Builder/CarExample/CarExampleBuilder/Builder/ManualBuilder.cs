using CarExampleBuilder.Engine;
using CarExampleBuilder.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CarExampleBuilder.Builder;

public class ManualBuilder : IBuilder
{
    private Manual _manual;

    public ManualBuilder()
    {
        Reset();
    }
    public Manual GetResult()
    {
        return _manual;
    }

    public void Reset()
    {
        _manual = new Manual();
    }

    public void SetEngine(EngineCar engine)
    {
        _manual.Engine = engine.ToString();
        Console.WriteLine(_manual.Engine);
    }

    public void SetGps()
    {
        _manual.Gps = "Gps is true";
        Console.WriteLine(_manual.Gps);
    }

    public void SetSeats(int number)
    {
        _manual.Seats = "The number of seats:"+ number;
        Console.WriteLine(_manual.Seats);
    }

    public void SetTripComputer()
    {
        _manual.ComputerTrip = "Trip Computer is true";
        Console.WriteLine(_manual.ComputerTrip);
    }
}
