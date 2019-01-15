List<int> values1 = new List<int>() { 1, 2, 3, 4 };

// Contains three values (1 and 2 also found in values1).
List<int> values2 = null ?? Enumerable.Empty<int>;

// Remove all values2 from values1.
var result = values1.Except(values2); // values 2 cannot be null

// Show.
foreach (var element in result)
{
    Console.WriteLine(element);
}