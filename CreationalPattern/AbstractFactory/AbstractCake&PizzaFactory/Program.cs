using AbstractCake_PizzaFactory.Domain.Enums;
using AbstractCake_PizzaFactory.Factory.AbstractFactory;

namespace AbstractCake_PizzaFactory;

internal class Program
{
    static void Main(string[] args)
    {
        var cakeFactory = DoughAbstractFactory.CreateDoughFactory(TypeDough.Cake);
        var pizzaFactory = DoughAbstractFactory.CreateDoughFactory(TypeDough.Pizza);

        var blueBerryCake = cakeFactory.CreateDough((TypeDough)TypeCake.BlueBerry);
        var chocolateCake = cakeFactory.CreateDough((TypeDough)TypeCake.Chocolate);


        var margheritaPizza = pizzaFactory.CreateDough((TypeDough)TypePizza.Margherita);
        var pepperoniPizza = pizzaFactory.CreateDough((TypeDough)TypePizza.Pepperoni);

       
        Console.WriteLine(blueBerryCake.Name);
        Console.WriteLine("/**************/");
        Console.WriteLine(chocolateCake.Name);
        Console.WriteLine("/**************/");
        Console.WriteLine(margheritaPizza.Name);
        Console.WriteLine("/**************/");
        Console.WriteLine(pepperoniPizza.Name);

    }
}
