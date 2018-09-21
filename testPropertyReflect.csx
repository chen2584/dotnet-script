object obj = 5555;

var properties = obj.GetType().GetProperties();

foreach(var property in properties)
{
    Console.WriteLine(property.Name);
}

Console.WriteLine("End...");