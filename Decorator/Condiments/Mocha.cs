namespace Decorator.Condiments;

public class Mocha(Beverage beverage) : CondimentDecorator
{
    public override string GetDescription()
    {
        return $"{beverage.GetDescription()}, Mocha";
    }

    public override double Cost()
    {
        return .20 + beverage.Cost();
    }
}