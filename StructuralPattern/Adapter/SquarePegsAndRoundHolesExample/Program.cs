using SquarePegsAndRoundHolesExample.RoundedHole;
using SquarePegsAndRoundHolesExample.RoundedPeg;
using SquarePegsAndRoundHolesExample.SuqarePegAdapter;

namespace SquarePegsAndRoundHolesExample;

internal class Program
{
    static void Main(string[] args)
    {
        var hole = new RoundedHole.RoundedHole(5);
        var roundPeg = new RoundedPeg.RoundedPeg(5);
        Console.WriteLine(hole.Fits(roundPeg)); // True

        var smallSquarePeg = new SquarePeg.SquarePeg(5);
        var largeSquarePeg = new SquarePeg.SquarePeg(10);

        var smallSquareAdapter = new SquarePegAdapter(smallSquarePeg);
        var largeSquareAdapter = new SquarePegAdapter(largeSquarePeg);

        Console.WriteLine(hole.Fits(smallSquareAdapter)); // True
        Console.WriteLine(hole.Fits(largeSquareAdapter)); // False
    }
}
