namespace PizzaShopSimpleFactory;

public abstract class Pizza
{
    public string Name { get; set; } = "GenericPizza";
    public abstract void Preparing();
    public abstract void Bake(int time);
    public abstract void Pack();
}
