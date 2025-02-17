using AbstractFurnitureFactory.Domain.Interfaces;
using AbstractFurnitureFactory.Domain.Products.Contemporary;
using AbstractFurnitureFactory.Factory.AbstractFactory;

namespace AbstractFurnitureFactory.Factory;

public class ContemporaryFactory : IFurnitureFactory
{
    public IChair CreateChair()
    {
        return new ComtemporaryChair();
    }

    public IBed CreateBed()
    {
        return new ComtemporaryBed();
    }

    public ICoffeTable CreateCoffeTable()
    {
        return new ComtemporaryCoffeTable();
    }
}
