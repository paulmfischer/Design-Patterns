namespace Decorator.Condiments;

public class Soy(Beverage beverage) : CondimentDecorator
{
    public override string GetDescription()
    {
        return $"{beverage.GetDescription()}, Soy";
    }

    public override double Cost()
    {
        return .40 + beverage.Cost();
    }
}
