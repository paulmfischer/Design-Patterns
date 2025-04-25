namespace Template;

public class Tea : CaffeineBeverage
{
    // public void PrepareRecipe()
    // {
    //     BoilWater();
    //     SteepTeaBag();
    //     PourInCup();
    //     AddLemon();
    // }
    //
    // private void BoilWater() => Console.WriteLine("Boiling Water");
    // private void SteepTeaBag() => Console.WriteLine("Steeping the tea");
    // private void PourInCup() => Console.WriteLine("Pouring In Cup");
    // private void AddLemon() => Console.WriteLine("Adding Lemon");
    
    protected override void Brew() => Console.WriteLine("Steeping the tea");

    protected override void AddCondiments() => Console.WriteLine("Adding Lemon");
}
