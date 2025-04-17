namespace Singleton;

public sealed class ModernSingleton
{
    private static readonly Lazy<ModernSingleton> lazyInstance =
        new Lazy<ModernSingleton>(() =>
        {
            Console.WriteLine($"Modern Singleton constructor called on thread {Environment.CurrentManagedThreadId}");
            Thread.Sleep(100);
            return new ModernSingleton();
        }, LazyThreadSafetyMode.ExecutionAndPublication);

    private ModernSingleton()
    {
    }
    
    public static ModernSingleton Instance => lazyInstance.Value;

    public void ShowMessage()
    {
        Console.WriteLine($"Modern Singleton show message called on thread {Environment.CurrentManagedThreadId}");
    }
}