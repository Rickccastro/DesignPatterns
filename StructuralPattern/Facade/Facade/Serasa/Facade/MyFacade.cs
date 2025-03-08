using Serasa.SubSystems;

namespace Serasa.Facade;

public class MyFacade
{
    private LimitCredit _limit;
    private SubSystems.Serasa _serasa;
    private Cadin _cadin;
    private Registry _registry;


    public MyFacade()
    {
        _limit = new LimitCredit();
        _serasa = new SubSystems.Serasa();
        _cadin = new Cadin();
        _registry = new Registry();
    }

    public bool AproveLoan(Client client, double value)
     {
        var aproveLoan = true;

        Console.WriteLine($"{client.Name}");


        if (_serasa.SerasaAvailable(client))
        {
            Console.WriteLine($"Client{client.Name}");
            aproveLoan = false;
        }
        else if (_cadin.CadinAvailable(client))
        {
            Console.WriteLine($"Client{client.Name}");
            aproveLoan = false; 
        }

        else if (!_limit.HasLimitCredit(client,value))
        {
            Console.WriteLine($"Client{client.Name}");
            aproveLoan = false;
        }
        return aproveLoan;
    }
}
