using AbstractCake_PizzaFactory.Domain.Enums;
using AbstractCake_PizzaFactory.Domain.Product;
using AbstractCake_PizzaFactory.Domain.Product.Cake;
using AbstractCake_PizzaFactory.Domain.Product.Pizza;
using System;

namespace AbstractCake_PizzaFactory.Factory.AbstractFactory;

public class PizzaFactory : DoughAbstractFactory
{
    public override DoughBase CreateDough(TypeDough typeDough)
    {
        var typePizza = (TypePizza)typeDough;

        switch (typePizza)
        {
            case TypePizza.Pepperoni:
                {
                    return new PepperoniPizza();
                }
            case TypePizza.Margherita:
                {
                    return new MargheritaPizza();
                }
            default:
                throw new ArgumentOutOfRangeException(nameof(typePizza), typePizza, null);
        }
    }
}
