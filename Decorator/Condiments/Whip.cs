namespace Decorator.Condiments;

public class Whip(Beverage beverage) : CondimentDecorator
{
    public override string GetDescription()
    {
        return $"{beverage.GetDescription()}, Whip";
    }

    public override double Cost()
    {
        return .15 + beverage.Cost();
    }
}
