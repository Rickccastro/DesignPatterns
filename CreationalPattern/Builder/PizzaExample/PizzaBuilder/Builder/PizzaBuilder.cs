using PizzaBuilder.Product;

namespace PizzaBuilder.Builder;

public abstract class PizzaBuilder
{
    protected Pizza pizza;
    public void CreatePizza()
    {
        pizza = new Pizza();    
    }
    public Pizza GetPizza()
    { 
         return pizza;
    }
    public abstract void MakingDough();
    public abstract void AddingComposition();
}
