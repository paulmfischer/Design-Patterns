namespace Factory;

public class NYPizzaIngredientFactory : IPizzaIngredientFactory
{
    public IDough CreateDough()
    {
        return new ThinCrustDough();
    }

    public ISauce CreateSauce()
    {
        return new MarinaraSauce();
    }

    public ICheese CreateCheese()
    {
        return new ReggianoCheese();
    }

    public List<IVeggies> CreateVeggies()
    {
        return [new Garlic(), new Onion(), new Mushroom(), new RedPepper()];
    }

    public IPepperoni CreatePepperoni()
    {
        return new SlicedPepperoni();
    }

    public IClams CreateClams()
    {
        return new FreshClams();
    }
}