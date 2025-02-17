using PizzaBuilder.ConcreteBuilder;
using PizzaBuilderExample.ConcreteBuilder;
using PizzaBuilderExample.Director;

namespace PizzaBuilder;

internal class Program
{
    static void Main(string[] args)
    {
        var pizzaShop = new PizzaShop(new PepperoniPizza());

        pizzaShop.CreatePizza();

        var pepperoniPizza = pizzaShop.GetPizza();
        pepperoniPizza.ShowPizzaInfo();


        var pizzaShop2 = new PizzaShop(new MargheritaPizza());

        pizzaShop2.CreatePizza();

        var margheritaPizza = pizzaShop.GetPizza();
        margheritaPizza.ShowPizzaInfo();

    }
}
