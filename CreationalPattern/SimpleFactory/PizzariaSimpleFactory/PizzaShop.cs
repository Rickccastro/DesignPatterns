namespace PizzaShopSimpleFactory;

public class PizzaShop
{
    public static void OrderPizza()
    {
        Console.WriteLine("Pizzaria Rickccastro");
        Console.WriteLine("Please choose your flavor of the pizza");
        Console.WriteLine("(M)argherita or (P)epperoni");
        var flavour = Console.ReadLine()!.ToUpper();
        try
        {
            Pizza pizza = PizzaSimpleFactory.CreatePizza(flavour);
            pizza.Preparing();
            pizza.Bake(10);
            pizza.Pack();
            Console.WriteLine("Pizza Ready.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro :" + ex.Message);
        }
    }
}
