using Serasa.Facade;
using Serasa.SubSystems;

namespace Serasa;

internal class Program
{
    static void Main(string[] args)
    {
        var myFacade = new MyFacade();
        var client = new Client("Rickccastro");

        bool result = myFacade.AproveLoan(client, 190000);
        Console.WriteLine(result);  
    }
}
