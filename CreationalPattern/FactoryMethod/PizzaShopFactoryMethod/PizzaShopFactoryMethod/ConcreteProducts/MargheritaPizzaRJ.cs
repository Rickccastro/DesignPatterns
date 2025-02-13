using System.Xml.Linq;
using PizzaShopFactoryMethod.Product;

namespace PizzaShopFactoryMethod.ConcreteProducts;

public class MargheritaPizzaRJ : Pizza
{
    public MargheritaPizzaRJ()
    {
        Name = "Margherita pizza from Rio de Janeiro";
        Dough = "Traditional dough from Rio";
        Souce = "Italian tomate souce";
        ingredients.Add("Fresh Tomatos");
        ingredients.Add("Special cheese");
    }
}
