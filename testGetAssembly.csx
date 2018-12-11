using System.Reflection;

class MyClass
{

}

var location = Assembly.GetAssembly(typeof(MyClass)).Location;

Console.WriteLine($"Location is {location}");