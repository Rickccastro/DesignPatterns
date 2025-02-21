using CarExampleBuilder.Builder;
using CarExampleBuilder.Models;

namespace CarExampleBuilder;

internal class Program
{
    static void Main(string[] args)
    {
       var director = new Director.Director();

        var carBuilder = new CarBuilder();
        director.MakeSportsCar(carBuilder);
        var sportsCar = carBuilder.GetResult();
        sportsCar.ShowInfo();

        var manualBuilder = new ManualBuilder();
        director.MakeSportsCar(manualBuilder);
        var manual = manualBuilder.GetResult();
        manual.ShowInfo();


        var carBuilder2 = new CarBuilder();
        director.MakeBrokenCar(carBuilder);
        var brokenCar = carBuilder.GetResult();
        brokenCar.ShowInfo();

        var manualBuilder2 = new ManualBuilder();
        director.MakeBrokenCar(manualBuilder2);
        var manual2 = manualBuilder2.GetResult();
        manual2.ShowInfo();
    }
}
