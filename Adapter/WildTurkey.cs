namespace Adapter;

public class WildTurkey: ITurkey
{
    public void Gobble()
    {
        Console.WriteLine("Gobble Gobble");
    }

    public void Fly()
    {
        Console.WriteLine("I'm flying a short distance");
    }
}