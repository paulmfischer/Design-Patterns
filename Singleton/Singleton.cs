namespace Singleton;

public sealed class SingletonObj
{
    private static SingletonObj _instance;

    private SingletonObj()
    {
    }

    public static SingletonObj GetInstance()
    {
        return _instance ??= new SingletonObj();
    }

    public void ShowMessage()
    {
        Console.WriteLine("Hi from the Singleton!");
    }
}