using AbstractFurnitureFactory.Factory;

namespace AbstractFurnitureFactory;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        var victorianFactory = new VictorianFactory();

        victorianFactory.CreateCoffeTable();
        victorianFactory.CreateChair();
        victorianFactory.CreateBed();

        var modernFactory = new ModernFactory();    

        modernFactory.CreateChair();
        modernFactory.CreateBed();
        modernFactory.CreateCoffeTable();

        var contemporaryFactory = new ContemporaryFactory();    

        contemporaryFactory.CreateChair();
        contemporaryFactory.CreateBed();
        contemporaryFactory.CreateCoffeTable(); 

    }
}
