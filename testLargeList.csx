var list = new List<string>();

for(var i = 0; i < 1000000; i++)
{
    list.Add(Guid.NewGuid().ToString()); // consume about 188mb.
}

Console.WriteLine($"Total Large: {list.Count}");
Console.WriteLine("Press any key to continue.");
Console.ReadLine();