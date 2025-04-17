namespace Singleton;

public sealed class ThreadSafeSingleton
{
    private static ThreadSafeSingleton _instance;
    private static readonly object Lock = new object();

    private ThreadSafeSingleton()
    {
    }

    public static ThreadSafeSingleton GetInstance()
    {
        if (_instance != null) return _instance;
        lock (Lock)
        {
            _instance ??= new ThreadSafeSingleton();
        }
        return _instance;
    }
    
    public void ShowMessage()
    {
        Console.WriteLine("Hi from the Thread Safe Singleton!");
    }
}