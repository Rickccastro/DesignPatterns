namespace PizzaBuilder.ConcreteBuilder;

public class PepperoniPizza : PizzaBuilder.Builder.PizzaBuilder
{
    public override void AddingComposition()
    {
        pizza.Name = "Pepperoni Pizza";
        pizza.Description = "Spicy Pepperoni Pizza";
        pizza.Ingredients = new List<string> { "Cheese", "Pepper", "Pepperoni" };
    }

    public override void MakingDough()
    {
        pizza.Dough = PizzaBuilder.Product.Enums.TypeDough.Regular;
        pizza.Size = PizzaBuilder.Product.Enums.PizzaSize.Large;
    }
}
