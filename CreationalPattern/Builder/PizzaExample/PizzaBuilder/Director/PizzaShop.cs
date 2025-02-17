using PizzaBuilder.Product;

namespace PizzaBuilderExample.Director;

public class PizzaShop
{
    private readonly PizzaBuilder.Builder.PizzaBuilder _builder;  
    public PizzaShop(PizzaBuilder.Builder.PizzaBuilder builder)
    {
        this._builder = builder;
    }

    public void CreatePizza()
    {
        _builder.CreatePizza();
        _builder.MakingDough();
        _builder.AddingComposition();   
    }

    public Pizza GetPizza()
    {
        return _builder.GetPizza();
    }
}
