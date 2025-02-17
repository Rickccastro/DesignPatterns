using AbstractCake_PizzaFactory.Domain.Enums;

namespace AbstractCake_PizzaFactory.Domain.Product.Cake;

public class BlueBerryCake : Cake
{
    public BlueBerryCake() : base("BlueBerryCake", TypeDough.Cake)
    {
        Ingredients.Add("Fresh BlueBerries");
    }
}
