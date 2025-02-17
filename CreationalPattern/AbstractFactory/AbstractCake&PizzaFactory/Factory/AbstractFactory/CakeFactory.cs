using AbstractCake_PizzaFactory.Domain.Enums;
using AbstractCake_PizzaFactory.Domain.Product;
using AbstractCake_PizzaFactory.Domain.Product.Cake;

namespace AbstractCake_PizzaFactory.Factory.AbstractFactory;

public class CakeFactory : DoughAbstractFactory
{
    public override DoughBase CreateDough(TypeDough typeDough)
    {
        var typeCake = (TypeCake)typeDough;

        switch (typeCake)
        {
            case TypeCake.BlueBerry:
                {
                    return new BlueBerryCake();
                }
            case TypeCake.Chocolate:
                {
                    return new ChocolateCake();
                }
            default:
                throw new ArgumentOutOfRangeException(nameof(typeCake), typeCake, null);

        }
    }
}

