using PizzaShopFactoryMethod.ConcreteProducts;
using PizzaShopFactoryMethod.Creator;
using PizzaShopFactoryMethod.Product;

namespace PizzaShopFactoryMethod.ConcreteCreator;

public class PizzaFactoryRJ : PizzaFactoryMethod
{
    protected override Pizza CreatePizza(string type)
    {
        if (type.Equals("P"))
        {
            return new PepperoniPizzaRJ();
        }
        if (type.Equals("M"))
        {
            return new MargheritaPizzaRJ();
        }
        else return null;
    }
}
