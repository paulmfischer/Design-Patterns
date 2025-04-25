namespace Template;

public class Coffee : CaffeineBeverage
{
    // public void PrepareRecipe()
    // {
    //     BoilWater();
    //     BrewCoffeeGrinds();
    //     PourInCup();
    //     AddSugarAndMilk();
    // }
    //
    // private void BoilWater() => Console.WriteLine("Boiling Water");
    // private void BrewCoffeeGrinds() => Console.WriteLine("Dripping Coffee through filter");
    // private void PourInCup() => Console.WriteLine("Pouring In Cup");
    // private void AddSugarAndMilk() => Console.WriteLine("Adding Sugar and Milk");
    
    protected override void Brew() => Console.WriteLine("Dripping Coffee through filter");

    protected override void AddCondiments() => Console.WriteLine("Adding sugar and milk");

    protected override bool CustomerWantsCondiments()
    {
        var answer = GetUserInput();

        return answer.ToLower() == "y";
    }

    private string GetUserInput()
    {
        Console.WriteLine("Would you like milk and sugar with your coffee (y/n)?");
        var response = Console.ReadLine()?.ToLower();

        return response ?? "n";
    }
}