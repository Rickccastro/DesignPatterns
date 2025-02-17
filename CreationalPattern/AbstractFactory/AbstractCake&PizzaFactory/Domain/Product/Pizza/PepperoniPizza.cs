using AbstractCake_PizzaFactory.Domain.Enums;

namespace AbstractCake_PizzaFactory.Domain.Product.Pizza;

public class PepperoniPizza : Pizza
{
    public PepperoniPizza() : base("PepperoniPizza", TypeDough.Pizza)
    {
        Ingredients.Add("Spicy peperonni");
    }
}
