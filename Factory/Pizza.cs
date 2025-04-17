namespace Factory;

public abstract class Pizza
{
    protected string Name { get; set; }
    protected IDough Dough { get; set; }
    protected ISauce Sauce { get; set; }
    protected List<IVeggies> Veggies { get; set; } = [];
    protected ICheese Cheese { get; set; }
    protected IPepperoni Pepperoni { get; set; }
    protected IClams Clams { get; set; }

    public abstract void Prepare();

    public void SetName(string name)
    {
        Name = name;
    }
    
    public virtual void Bake()
    {
        Console.WriteLine("Baking for 25 minutes at 350");
    }
    
    public virtual void Cut()
    {
        Console.WriteLine("Cutting pizza into diagonal slices");
    }
    
    public virtual void Box()
    {
        Console.WriteLine("Boxing pizza");
    }
}

public class CheesePizza(IPizzaIngredientFactory ingredientFactory) : Pizza
{
    public override void Prepare()
    {
        Console.WriteLine($"Preparing {Name}");
        Dough = ingredientFactory.CreateDough();
        Sauce = ingredientFactory.CreateSauce();
        Cheese = ingredientFactory.CreateCheese();
    }
}

public class VeggiePizza(IPizzaIngredientFactory ingredientFactory) : Pizza
{
    public override void Prepare()
    {
        Console.WriteLine($"Preparing {Name}");
        Dough = ingredientFactory.CreateDough();
        Sauce = ingredientFactory.CreateSauce();
        Cheese = ingredientFactory.CreateCheese();
        Veggies = ingredientFactory.CreateVeggies();
    }
}

public class PepperoniPizza(IPizzaIngredientFactory ingredientFactory) : Pizza
{
    public override void Prepare()
    {
        Console.WriteLine($"Preparing {Name}");
        Dough = ingredientFactory.CreateDough();
        Sauce = ingredientFactory.CreateSauce();
        Cheese = ingredientFactory.CreateCheese();
        Pepperoni = ingredientFactory.CreatePepperoni();
    }
}

public class ClamPizza(IPizzaIngredientFactory ingredientFactory) : Pizza
{
    public override void Prepare()
    {
        Console.WriteLine($"Preparing {Name}");
        Dough = ingredientFactory.CreateDough();
        Sauce = ingredientFactory.CreateSauce();
        Cheese = ingredientFactory.CreateCheese();
        Clams = ingredientFactory.CreateClams();
    }
}