namespace Serasa.SubSystems;

public class Cadin
{
    public bool  CadinAvailable(Client client)
    {
        Console.WriteLine($"Verifying Cadin for Client{ client.Name}");
        return false;
    }      
}
