using AbstractCake_PizzaFactory.Domain.Enums;
using AbstractCake_PizzaFactory.Domain.Product;

namespace AbstractCake_PizzaFactory.Factory.AbstractFactory;

public abstract class DoughAbstractFactory
{
    public abstract DoughBase CreateDough(TypeDough typeDough);

    public static DoughAbstractFactory CreateDoughFactory(TypeDough typeDough)
    {
        switch (typeDough)
        {
            case TypeDough.Pizza:
                {
                    return new PizzaFactory();
                }
            case TypeDough.Cake:
                {
                    return new CakeFactory();
                }
            default:
                throw new ArgumentOutOfRangeException(nameof(typeDough), typeDough, null);

        }
    }
}
