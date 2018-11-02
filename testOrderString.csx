var strList = new List<string>() { "11.1", "11", "11.2" };
var result = strList.OrderBy(x => x);

Console.WriteLine($"{string.Join(", ", result)}"); // 11, 11.1, 11.2