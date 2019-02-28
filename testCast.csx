var list = new List<object> { "12345", 555, "6789" };

var listString = list.Cast<string>(); // Oftype will cast only safely type
foreach(var item in listString)
{
    Console.WriteLine(item);
}