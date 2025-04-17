namespace Factory;

public interface IPizzaIngredientFactory
{
    IDough CreateDough();
    ISauce CreateSauce();
    ICheese CreateCheese();
    List<IVeggies> CreateVeggies();
    IPepperoni CreatePepperoni();
    IClams CreateClams();
}

public interface IDough
{
}

public class ThinCrustDough : IDough
{
}

public class ThickCrustDough : IDough
{
}

public interface ISauce
{
}

public class MarinaraSauce : ISauce
{
}

public class PlumTomatoSauce : ISauce
{
}

public interface ICheese
{
}
public class ReggianoCheese : ICheese
{}

public class ShreddedMozzarellaCheese : ICheese
{
}

public interface IVeggies
{
}

public class Garlic : IVeggies
{
}

public class Onion : IVeggies
{
}

public class Mushroom : IVeggies
{
}

public class RedPepper : IVeggies
{
}

public interface IPepperoni
{
}

public class SlicedPepperoni : IPepperoni
{
}

public interface IClams
{
}
public class FreshClams: IClams{}