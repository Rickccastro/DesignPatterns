using AbstractFurnitureFactory.Domain.Interfaces;
using AbstractFurnitureFactory.Domain.Products.Victorian;
using AbstractFurnitureFactory.Factory.AbstractFactory;

namespace AbstractFurnitureFactory.Factory;

public class VictorianFactory : IFurnitureFactory
{
    public IChair CreateChair()
    {
        return new VictorianChair();
    }

    public IBed CreateBed()
    {
        return new VictorianBed();
    }

    public ICoffeTable CreateCoffeTable()
    {
       return new VictorianCoffeTable();
    }
}
