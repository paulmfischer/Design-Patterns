namespace Decorator.Drinks;

public class Espresso : Beverage
{
    public Espresso()
    {
        Description = "Espresso";
    }
    
    public override double Cost()
    {
        return 1.99;
    }
}