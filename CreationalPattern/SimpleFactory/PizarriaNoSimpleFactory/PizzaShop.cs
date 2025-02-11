namespace PizzaShopNoSimpleFactory;

public class PizzaShop
{
    public static void OrderPizza()
    {
        MargheritaPizza pizza1;
        PepperoniPizza pizza2;

        Console.WriteLine("Pizzaria Rickccastro");
        Console.WriteLine("Please choose your flavor of the pizza");
        Console.WriteLine("(M)argherita or (P)epperoni");
        var chosenPizza = Console.ReadLine()!.ToUpper();

        if (chosenPizza.Equals("M"))
        {
            pizza1 = new MargheritaPizza();
            pizza1.Preparing();
            pizza1.Bake(10);
            pizza1.Pack();
            Console.WriteLine("pizza ready");
        }
        else if (chosenPizza.Equals("P"))
        {
            pizza2 = new PepperoniPizza();
            pizza2.Preparing();
            pizza2.Bake(10);
            pizza2.Pack();
            Console.WriteLine("pizza concluida");
        }
        else
        {
            Console.WriteLine("Essa pizza não existe");
            return;
        }
    }
}
