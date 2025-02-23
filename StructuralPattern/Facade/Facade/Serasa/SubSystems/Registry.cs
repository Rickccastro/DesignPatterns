namespace Serasa.SubSystems;

public class Registry
{

    public void RegistryClient(Client client)
    {
        Console.WriteLine($"Client{client.Name} Registred");
    }
}
