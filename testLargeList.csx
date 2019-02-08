var list = new List<string>();

foreach(var num in Enumerable.Range(0, 1000000))
{
    list.Add(Guid.NewGuid().ToString()); // consume about 188mb.
}

Console.WriteLine($"Total Large: {list}");
Console.WriteLine("Press any key to continue.");
Console.ReadLine();