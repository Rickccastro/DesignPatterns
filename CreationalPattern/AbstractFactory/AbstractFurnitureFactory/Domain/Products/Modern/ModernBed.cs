using AbstractFurnitureFactory.Domain.Interfaces;

namespace AbstractFurnitureFactory.Domain.Products.Modern;

public class ModernBed : IBed
{
    public string Name => throw new NotImplementedException();

    public void SitOnBed()
    {
        throw new NotImplementedException();
    }

    public void SleepOnBed()
    {
        throw new NotImplementedException();
    }
}
