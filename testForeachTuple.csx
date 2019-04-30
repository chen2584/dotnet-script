var list = new string[] { "A", "B", "C" };

foreach(var (index, data) in list.Select((x, i) => (i, x)))
{
    Console.WriteLine("{0}: {1}", index, data);
}