namespace Serasa.SubSystems;

public class Serasa
{
    public bool SerasaAvailable(Client client)
    {
        Console.WriteLine($"Verifying Serasa for Client{client.Name}");
        return false;
    }
}
