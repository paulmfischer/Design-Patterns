namespace Template;

public abstract class CaffeineBeverage
{
    // template method
    // serves as a template for an algorithm
    // each step is represented by a method
    // some are abstract requiring concrete class to implement
    public void PrepareRecipe()
    {
        BoilWater();
        Brew();
        PourInCup();
        if (CustomerWantsCondiments())
        {
            AddCondiments();
        }
    }

    private void BoilWater() => Console.WriteLine("Boiling water");
    
    private void PourInCup() => Console.WriteLine("Pouring in cup");

    protected abstract void Brew();

    protected abstract void AddCondiments();

    protected virtual bool CustomerWantsCondiments()
    {
        return true;
    }
}