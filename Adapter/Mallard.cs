namespace Adapter;

public class Mallard : IDuck
{
    public void Quack()
    {
        Console.WriteLine("Quack");
    }

    public void Fly()
    {
        Console.WriteLine("I'm flying");
    }
}