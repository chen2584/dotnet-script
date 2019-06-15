using System.Threading;

SynchronizationContext context = SynchronizationContext.Current;

public async Task<bool> TestMethod()
{
    await Task.Delay(1000);
    Console.WriteLine("Hello World!");
    return true;
}

context = context ?? new SynchronizationContext();
Console.WriteLine($"current thread: {Thread.CurrentThread.ManagedThreadId}");
var result = await TestMethod();
context.Post(new SendOrPostCallback((o) =>
{
    Console.WriteLine($"Execute on thread: {Thread.CurrentThread.ManagedThreadId}");
}), null); // this will run the same thread
