namespace Composite;

public class MenuItem(string name, string description, bool vegetarian, double price): MenuComponent
{
    public override string GetName()
    {
        return name;
    }

    public override string GetDescription()
    {
        return description;
    }

    public override double GetPrice()
    {
        return price;
    }

    public override bool IsVegetarian()
    {
        return vegetarian;
    }

    public override void Print()
    {
        Console.Write($"{GetName()}");
        if (IsVegetarian())
        {
            Console.Write(" (v)");
        }
        
        Console.Write($", {GetPrice()}");
        Console.Write($" -- {GetDescription()}\n");
    }
}