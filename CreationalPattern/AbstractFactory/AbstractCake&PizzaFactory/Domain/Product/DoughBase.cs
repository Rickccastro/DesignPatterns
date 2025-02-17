using AbstractCake_PizzaFactory.Domain.Enums;
using System.Collections;

namespace AbstractCake_PizzaFactory.Domain.Product;

public abstract class DoughBase
{
    public TypeDough TypeDough { get; set; }
    public string Name { get; set; }

    public ArrayList Ingredients = new ArrayList();
    public DoughBase(string name, TypeDough typeDough)
    {
        Name = name;
        TypeDough = typeDough;
    }
}
