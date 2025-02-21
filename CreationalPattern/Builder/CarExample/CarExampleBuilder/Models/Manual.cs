namespace CarExampleBuilder.Models;

public class Manual
{
    public string Content { get; set; } = "Car Manual Contents";
    public string Gps { get; set; } = string.Empty;
    public string Seats { get; set; } = string.Empty;
    public string Engine { get; set; } = string.Empty;
    public string ComputerTrip { get; set; } = string.Empty;

    public void ShowInfo()
    {
        Console.WriteLine($"{Content},Seats: {Seats}, Engine: {Engine}, TripComputer: {ComputerTrip}, GPS: {Gps}");
    }
}
