using SquarePegsAndRoundHolesExample.RoundedHole;

namespace SquarePegsAndRoundHolesExample.RoundedPeg;

public class RoundedPeg 
{
    private int radius;

    public RoundedPeg()
    {
        
    }
    public RoundedPeg(int radius)
    {
        this.radius = radius;
    }

    public virtual int GetRadius()
    {
        return radius;
    }
}
