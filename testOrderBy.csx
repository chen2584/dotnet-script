var str = new List<string>()
{
    "1/2561",
    "2/2560",
    "2/2561"
};

var result = str.OrderBy(x => x);

Console.WriteLine(string.Join(", ", result));