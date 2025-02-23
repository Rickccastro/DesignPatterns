namespace Serasa.SubSystems;

public class LimitCredit
{
    public bool HasLimitCredit(Client client, double value)
    {
        Console.WriteLine($"Verifying credit limit for {client.Name}");
       
        if(value > 200000)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}
