using AbstractCake_PizzaFactory.Domain.Enums;

namespace AbstractCake_PizzaFactory.Domain.Product.Pizza;

public class MargheritaPizza : Pizza
{
    public MargheritaPizza() : base("MargheritaPizza",TypeDough.Pizza)
    {
        Ingredients.Add("Fresh cheese");
    }
}
