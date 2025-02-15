namespace PizzaShopNoSimpleFactory;

public class MargheritaPizza
{
    public string Name { get; set; }
    public MargheritaPizza()
    {
        Name = "Margherita";
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
