// See https://aka.ms/new-console-template for more information

using Singleton;

var singleton1 = SingletonObj.GetInstance();
var singleton2 = SingletonObj.GetInstance();

Console.WriteLine($"Same singleton instance: {ReferenceEquals(singleton1, singleton2)}");
singleton1.ShowMessage();
//
// var threadSafe1 = ThreadSafeSingleton.GetInstance();
// var threadSafe2 = ThreadSafeSingleton.GetInstance();
// Console.WriteLine($"Same thread-safe instance? {ReferenceEquals(threadSafe1, threadSafe2)}");
// threadSafe1.ShowMessage();
//
Console.WriteLine("Starting Singleton Pattern Demo with Multiple Threads");
Console.WriteLine($"Main thread ID: {Environment.CurrentManagedThreadId}");
Console.WriteLine("--------------------------------------------------------");

// Demonstrating thread-safe singleton
Console.WriteLine("\nTesting Thread-Safe Singleton with multiple threads:");
TestThreadSafeSingleton();

// Give time for all threads to complete
Thread.Sleep(1000);
        
// Demonstrating modern singleton
Console.WriteLine("\nTesting Modern Singleton with multiple threads:");
TestModernSingleton();
return;

static void TestThreadSafeSingleton()
{
    // Create tasks to get the singleton instance from multiple threads
    var tasks = new Task[5];
    for (var i = 0; i < tasks.Length; i++)
    {
        tasks[i] = Task.Run(() => 
        {
            Console.WriteLine($"Thread {Environment.CurrentManagedThreadId} trying to get ThreadSafeSingleton instance.");
            var singleton = ThreadSafeSingleton.GetInstance();
            singleton.ShowMessage();
        });
    }
        
    // Wait for all tasks to complete
    Task.WaitAll(tasks);
        
    // Verify it's the same instance from the main thread
    var mainThreadInstance = ThreadSafeSingleton.GetInstance();
    mainThreadInstance.ShowMessage();
    Console.WriteLine("All threads accessed the same ThreadSafeSingleton instance!");
}
    
static void TestModernSingleton()
{
    // Create tasks to get the singleton instance from multiple threads
    var tasks = new Task[5];
    for (var i = 0; i < tasks.Length; i++)
    {
        tasks[i] = Task.Run(() => 
        {
            Console.WriteLine($"Thread {Environment.CurrentManagedThreadId} trying to get ModernSingleton instance.");
            var singleton = ModernSingleton.Instance;
            singleton.ShowMessage();
        });
    }
        
    // Wait for all tasks to complete
    Task.WaitAll(tasks);
        
    // Verify it's the same instance from the main thread
    var mainThreadInstance = ModernSingleton.Instance;
    mainThreadInstance.ShowMessage();
    Console.WriteLine("All threads accessed the same ModernSingleton instance!");
}