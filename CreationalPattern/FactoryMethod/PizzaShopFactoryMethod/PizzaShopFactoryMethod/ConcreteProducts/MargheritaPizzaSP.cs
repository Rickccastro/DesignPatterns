using PizzaShopFactoryMethod.Product;

namespace PizzaShopFactoryMethod.ConcreteProducts;

public class MargheritaPizzaSP : Pizza
{
    public MargheritaPizzaSP()
    {
        Name = "Margherita pizza from Sao Paulo";
        Dough = "Traditional dough from Sao Paulo";
        Souce = "Italian tomate souce";
        ingredients.Add("Fresh Tomatos");
        ingredients.Add("Special cheese");
    }
}
