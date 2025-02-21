using CarExampleBuilder.Engine;

namespace CarExampleBuilder.Models;

public class Car
{
    public int Seats { get; set; }
    public EngineCar Engine { get; set; }    
    public bool HasTripComputer { get; set; }
    public bool HasGPS { get; set; }

    public void ShowInfo()
    {
        Console.WriteLine($"Seats: {Seats}, Engine: {Engine}, TripComputer: {HasTripComputer}, GPS: {HasGPS}");
    }
}
