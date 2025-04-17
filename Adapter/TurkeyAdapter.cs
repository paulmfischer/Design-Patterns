namespace Adapter;

public class TurkeyAdapter(ITurkey turkey) : IDuck
{
    public void Quack()
    {
        turkey.Gobble();
    }

    public void Fly()
    {
        for (var i = 0; i < 5; i++)
        {
            turkey.Fly();
        }
    }
}