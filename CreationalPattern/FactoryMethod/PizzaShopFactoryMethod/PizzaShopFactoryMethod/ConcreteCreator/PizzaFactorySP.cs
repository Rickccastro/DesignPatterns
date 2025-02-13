using PizzaShopFactoryMethod.ConcreteProducts;
using PizzaShopFactoryMethod.Creator;
using PizzaShopFactoryMethod.Product;

namespace PizzaShopFactoryMethod.ConcreteCreator;

public class PizzaFactorySP : PizzaFactoryMethod
{
    protected override Pizza CreatePizza(string type)
    {
        if (type.Equals("P"))
        {
            return new PepperoniPizzaSP();
        }
        if (type.Equals("M"))
        {
            return new MargheritaPizzaSP();
        }
        else return null;
    }
}
