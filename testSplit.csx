var value = "Name Chenz ";
var splitValue = value.Split(" ", StringSplitOptions.RemoveEmptyEntries);
Console.WriteLine($"Length: {splitValue.Length}");

foreach(var val in splitValue)
{
    Console.WriteLine($"Value: {val}");
}