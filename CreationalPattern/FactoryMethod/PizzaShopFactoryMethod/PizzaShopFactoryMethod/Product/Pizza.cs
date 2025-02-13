using System.Collections;
using System.Text;

namespace PizzaShopFactoryMethod.Product;

//Product
public abstract class Pizza
{
    protected string Name { get; set; }
    protected string Dough;
    protected string Souce;
    protected ArrayList ingredients = new ArrayList();

    public string Preparing()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("Preparing " + Name + "\n");
        sb.Append(Dough + "\n");
        sb.Append(Souce + "\n");
        sb.Append("Ingredients :" + "\n");
        foreach (string ingrediente in ingredients)
        {
            sb.Append("\t" + ingrediente + "\n");
        }
        sb.Append(Baking());
        sb.Append(Slices());
        sb.Append(Packing());
        return sb.ToString();
    }

    public virtual string Baking()
    {
        return "Cook for 25 minutes at 350 degrees\r\n";
    }
    public virtual string Slices()
    {
        return "Slice the pizza into 8 pieces\n";
    }
    public virtual string Packing()
    {
        return "Pack the pizza in the official packaging\n";
    }
}