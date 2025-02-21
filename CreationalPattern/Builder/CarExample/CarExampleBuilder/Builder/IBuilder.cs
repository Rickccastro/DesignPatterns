using CarExampleBuilder.Engine;

namespace CarExampleBuilder.Builder;

public interface IBuilder
{
    public void Reset();
    public void SetSeats(int number);
    public void SetEngine(EngineCar engine);
    public void SetTripComputer();
    public void SetGps();
}
