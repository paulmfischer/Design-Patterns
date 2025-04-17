namespace Decorator;

public abstract class Beverage
{
    protected string Description { get; init; } = "Unknown Beverage";
    
    public virtual string GetDescription()
    {
        return Description;
    }
    
    public abstract double Cost();
}