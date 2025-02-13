using System.Xml.Linq;
using PizzaShopFactoryMethod.Product;

namespace PizzaShopFactoryMethod.ConcreteProducts;

public class PepperoniPizzaSP : Pizza
{
    public PepperoniPizzaSP()
    {
        Name = "Pepperoni pizza from Sao Paulo";
        Dough = "Traditional dough from Sao Paulo";
        Souce = "Italian tomate souce";
        ingredients.Add("Special pepperoni");
        ingredients.Add("Special cheese");
    }
}
