using PizzaBuilder.Builder;

namespace PizzaBuilderExample.ConcreteBuilder;

public class MargheritaPizza : PizzaBuilder.Builder.PizzaBuilder
{
    
    public override void AddingComposition()
    {
        pizza.Name = "Margherita Pizza";
        pizza.Description = "Delicious Margherita Pizza";
        pizza.Ingredients = new List<string> { "Cheese", "Oregano", "Basil" };
    }

    public override void MakingDough()
    {
        pizza.Dough = PizzaBuilder.Product.Enums.TypeDough.Regular;
        pizza.Size = PizzaBuilder.Product.Enums.PizzaSize.Large;
    }
}
