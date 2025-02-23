using SquarePegsAndRoundHolesExample.RoundedHole;
using SquarePegsAndRoundHolesExample.SquarePeg;

namespace SquarePegsAndRoundHolesExample.SuqarePegAdapter;

public class SquarePegAdapter : RoundedPeg.RoundedPeg
{
    private SquarePeg.SquarePeg peg;

    public SquarePegAdapter(SquarePeg.SquarePeg peg) 
    {
        this.peg = peg;
    }

    public override int GetRadius()
    {
        return (int)(peg.GetWidth() * Math.Sqrt(2) / 2);
    }
}


