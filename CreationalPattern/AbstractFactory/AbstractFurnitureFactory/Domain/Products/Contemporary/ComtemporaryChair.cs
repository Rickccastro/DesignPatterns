using AbstractFurnitureFactory.Domain.Interfaces;

namespace AbstractFurnitureFactory.Domain.Products.Contemporary;

public class ComtemporaryChair : IChair
{
    public string Name => throw new NotImplementedException();

    public void SitOn()
    {
        throw new NotImplementedException();
    }

    public void StepOn()
    {
        throw new NotImplementedException();
    }
}
