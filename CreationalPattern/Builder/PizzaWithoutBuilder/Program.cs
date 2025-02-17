namespace PizzaWithoutBuilder;

internal class Program
{
    static void Main(string[] args)
    {
        var pizza = new Pizza("Pepperoni", "Spice pepperoni pizza",Enums.PizzaSize.Large , Enums.TypeDough.Regular, new List<string> { "Cheese", "Pepperoni", "Oregano" });
    
        pizza.ShowPizzaInfo();
    }
}
