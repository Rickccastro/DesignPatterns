using AbstractCake_PizzaFactory.Domain.Enums;

namespace AbstractCake_PizzaFactory.Domain.Product.Cake;

public class ChocolateCake : Cake
{
    public ChocolateCake() : base("Chocolate Cake", TypeDough.Cake)
    {
        Ingredients.Add("Special Chocolate");
    }
}
