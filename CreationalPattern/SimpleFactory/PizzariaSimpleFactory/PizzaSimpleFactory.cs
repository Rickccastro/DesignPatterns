using PizzaShopSimpleFactory.Flavours;

namespace PizzaShopSimpleFactory;

sealed class PizzaSimpleFactory
{
   public static Pizza CreatePizza(string flavour)
    {
        Pizza pizza;
        switch (flavour)
        {
            case "P":
                pizza = new PepperoniPizza();
                break;
            case "M":
                pizza = new MargheritaPizza();
                break;
            default:
                throw new ApplicationException($"the flavour'{flavour}' was not created");
        }
        return pizza;
    }
        
}
