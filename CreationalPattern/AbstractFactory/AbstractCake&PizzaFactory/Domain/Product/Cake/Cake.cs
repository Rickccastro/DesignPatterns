using AbstractCake_PizzaFactory.Domain.Enums;

namespace AbstractCake_PizzaFactory.Domain.Product.Cake;

public class Cake : DoughBase
{
    public Cake(string name, TypeDough typeDough) : base(name, typeDough)
    {
    }
}
