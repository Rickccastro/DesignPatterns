using AbstractFurnitureFactory.Domain.Interfaces;
using AbstractFurnitureFactory.Domain.Products.Contemporary;
using AbstractFurnitureFactory.Domain.Products.Modern;
using AbstractFurnitureFactory.Factory.AbstractFactory;

namespace AbstractFurnitureFactory.Factory;

public class ModernFactory : IFurnitureFactory
{
    public IChair CreateChair()
    {
        return new ModernChair();
    }

    public IBed CreateBed()
    {
        return new ModernBed();
    }

    public ICoffeTable CreateCoffeTable()
    {
        return new ModernCoffeTable();
    }
}
