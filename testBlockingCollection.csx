using System.Collections.Concurrent;

var collection = new BlockingCollection<string>();
collection.Add("Hello");
collection.Add("World!");

var take1 = collection.Take();
Console.WriteLine($"Take1 is {take1}");

var take2 = collection.Take();
Console.WriteLine($"Take2 is {take2}");

collection.Take();
Console.WriteLine("This line will not reach");