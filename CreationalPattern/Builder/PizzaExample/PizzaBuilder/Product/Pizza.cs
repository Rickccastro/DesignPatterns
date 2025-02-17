using PizzaBuilder.Product.Enums;

namespace PizzaBuilder.Product;

public class Pizza
{
    public string Name { get; set; } = "Generic Pizza";
    public string Description { get; set; } = "Generic Description";
    public PizzaSize Size { get; set; }
    public TypeDough Dough { get; set; }
    public List<string> Ingredients { get; set; } 

    public void ShowPizzaInfo()
    {
        Console.WriteLine("Pizza:" + Name);
        Console.WriteLine("Description:" + Description);
        Console.WriteLine("Size" + Size);
        Console.WriteLine("Dough" + Dough);

        foreach (var items in Ingredients)
        {
            Console.WriteLine(items);
        }
    }
}
