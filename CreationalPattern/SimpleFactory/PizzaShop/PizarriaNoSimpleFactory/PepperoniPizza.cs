namespace PizzaShopNoSimpleFactory;

public class PepperoniPizza
{
    public string Name { get; set; }


    public PepperoniPizza()
    {
        Name = "Pepperoni";
    }
    public void Preparing()
    {
        Console.WriteLine($"\n Preparing the pizza {Name}");
    }

    public void Bake(int time)
    {
        Console.WriteLine($"Baking the {Name} pizza for {time} min.");
    }

    public void Pack()
    {
        Console.WriteLine($"Pack the {Name} pizza for delivery\n");
    }
}
