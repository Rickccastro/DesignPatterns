using CarExampleBuilder.Builder;
using CarExampleBuilder.Engine;

namespace CarExampleBuilder.Director;

public class Director
{
    public void MakeBrokenCar(IBuilder builder)
    {
        builder.Reset();
        builder.SetSeats(3);
        builder.SetTripComputer();
        builder.SetGps();
    }

    public void MakeSportsCar(IBuilder builder)
    {
        builder.Reset();
        builder.SetSeats(2);
        builder.SetEngine(new SportsCar());
        builder.SetTripComputer();
        builder.SetGps();
    }

    public void MakeRegularCar(IBuilder builder)
    {
        builder.Reset();
        builder.SetSeats(5);
        builder.SetEngine(new RegularEngine());
        builder.SetTripComputer();
        builder.SetGps();
    }
}
