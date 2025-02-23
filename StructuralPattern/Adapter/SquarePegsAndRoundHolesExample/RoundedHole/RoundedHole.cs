using SquarePegsAndRoundHolesExample.RoundedPeg;

namespace SquarePegsAndRoundHolesExample.RoundedHole;

public class RoundedHole 
{
    private int radius;

    public RoundedHole(int radius)
    {
        this.radius = radius;
    }

    public int GetRadius()
    {
        return radius;
    }

    public bool Fits(RoundedPeg.RoundedPeg peg)
    {
        if (peg.GetRadius() > this.radius)
            return false;
        return true;

    }
}
