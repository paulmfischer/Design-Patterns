namespace Factory;

public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
{
    public IDough CreateDough()
    {
        return new ThickCrustDough();
    }

    public ISauce CreateSauce()
    {
        return new PlumTomatoSauce();
    }

    public ICheese CreateCheese()
    {
        return new ShreddedMozzarellaCheese();
    }

    public List<IVeggies> CreateVeggies()
    {
        return [new Garlic(), new Mushroom(), new RedPepper()];
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