using PizzaShopFactoryMethod.Creator;

namespace PizzaShopFactoryMethod;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("========= Pizzaria ======\n");
        Console.WriteLine("Choose your location (S)São Paulo  (R)Rio de Janeiro");
        var choosenLocation = Console.ReadLine().ToUpper();

        Console.WriteLine("Choose your flavor for the pizza (M)argherita  (P)epperoni");
        var choosenPizza = Console.ReadLine().ToUpper();

        try
        {
            var pizzaShop = PizzaConcreteFactory.CreatePizzaShop(choosenLocation);

            var pizza = pizzaShop.BuildPizza(choosenPizza);

            Console.WriteLine(pizza.Preparing());
            Console.WriteLine($"\nThe pizza is ready");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro :" + ex.Message);
        }
        Console.ReadLine();
    }
}
