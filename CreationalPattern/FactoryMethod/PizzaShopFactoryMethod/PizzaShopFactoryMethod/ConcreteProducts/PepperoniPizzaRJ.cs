using PizzaShopFactoryMethod.Product;

namespace PizzaShopFactoryMethod.ConcreteProducts;

public class PepperoniPizzaRJ : Pizza
{

    public PepperoniPizzaRJ()
    {
        Name = "Pepperoni pizza from Rio de Janeiro";
        Dough = "Traditional dough from Rio";
        Souce = "Italian tomate souce";
        ingredients.Add("Special pepperoni");
        ingredients.Add("Special cheese");
    }  
}
