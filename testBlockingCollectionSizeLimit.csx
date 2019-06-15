using System.Collections.Concurrent;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

var blockingCollection = new BlockingCollection<int>(1) { 1 };
Console.WriteLine(blockingCollection.TryAdd(2)); // false
