using System.Collections.Concurrent;

var blockingCollection = new BlockingCollection<int>(1) { 1 };
Console.WriteLine(blockingCollection.TryAdd(2)); // false