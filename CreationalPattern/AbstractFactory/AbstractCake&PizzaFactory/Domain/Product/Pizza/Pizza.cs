using AbstractCake_PizzaFactory.Domain.Enums;

namespace AbstractCake_PizzaFactory.Domain.Product.Pizza;

public class Pizza : DoughBase
{
    public Pizza(string name, TypeDough typeDough) : base(name, typeDough)
    {
    }
}
