using PizzaWithoutBuilder.Enums;

namespace PizzaWithoutBuilder;

public class Pizza
{
    private readonly string _name;
    private readonly string _description;
    private readonly PizzaSize _size;
    private readonly TypeDough _dough;
    private readonly List<string> ingredients;

    public Pizza(string name, string description, PizzaSize size, TypeDough dough, List<string> ingredients)
    {
        _name = name;
        _description = description;
        _size = size;
        _dough = dough;
        this.ingredients = ingredients;
    }

    public void ShowPizzaInfo()
    {
        Console.WriteLine("Pizza:" + _name);
        Console.WriteLine("Description:" + _description);
        Console.WriteLine("Size" + _size);
        Console.WriteLine("Dough" + _dough);

        foreach (var items in ingredients)
        {
            Console.WriteLine(items);
        }
    }
}
