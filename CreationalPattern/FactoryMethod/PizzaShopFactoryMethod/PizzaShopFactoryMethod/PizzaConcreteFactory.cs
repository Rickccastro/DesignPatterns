using PizzaShopFactoryMethod.ConcreteCreator;
using PizzaShopFactoryMethod.Creator;

namespace PizzaShopFactoryMethod;

public class PizzaConcreteFactory
{
    public static PizzaFactoryMethod CreatePizzaShop(string location)
    {
        PizzaFactoryMethod pizzaria;
        switch (location)
        {
            case "S":
                pizzaria = new PizzaFactorySP();
                break;
            case "R":
                pizzaria = new PizzaFactoryRJ();
                break;
            default:
                throw new ApplicationException($"The pizza shop {location} has not been created");
        }
        return pizzaria;
    }
}
