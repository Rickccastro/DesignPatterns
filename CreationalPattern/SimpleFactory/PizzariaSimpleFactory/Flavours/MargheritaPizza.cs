using System.Xml.Linq;

namespace PizzaShopSimpleFactory.Flavours;

public class MargheritaPizza : Pizza
{
    public MargheritaPizza()
    {
        Name = "Margherita Pizza";
    }
    public override void Preparing()
    {
        Console.WriteLine($"\n Preparing the pizza {Name}");
    }

    public override void Bake(int time)
    {
        Console.WriteLine($"Baking the {Name} pizza for {time} min.");
    }

    public override void Pack()
    {
        Console.WriteLine($"Pack the {Name} pizza for delivery\n");
    }
}
