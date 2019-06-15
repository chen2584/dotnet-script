using System.Collections.Concurrent;

var collection = new BlockingCollection<string>();
Task.Run(() => 
{
    Task.Delay(1000).GetAwaiter();
    collection.CompleteAdding();
});
Console.WriteLine("Starting Take from list");
Console.WriteLine(collection.Take());
// Console.WriteLine("Hello World! " + value);

// System.InvalidOperationException: The collection argument is empty and has been marked as complete with regards to additions.