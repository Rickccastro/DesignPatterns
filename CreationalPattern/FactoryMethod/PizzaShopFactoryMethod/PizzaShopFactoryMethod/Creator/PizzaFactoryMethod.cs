using PizzaShopFactoryMethod.Product;

namespace PizzaShopFactoryMethod.Creator;

public abstract class PizzaFactoryMethod
{
    //Creator
    public Pizza BuildPizza(string type)
    {
        Pizza pizza;
        pizza = CreatePizza(type);
        return pizza;
    }
    protected abstract Pizza CreatePizza(string tipo);
}
