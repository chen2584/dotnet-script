using System.Reflection;

class MyClass
{
    private string PrintHello(string firstName, string lastName)
    {
        return $"Hello World {firstName} {lastName}";
    }
}

var first = "Chen";
var last = "Angelo";
var myClass = new MyClass();

// If Method is not defined, methodInfo will be null
var methodInfo = myClass.GetType().GetMethod("PrintHello", BindingFlags.NonPublic | BindingFlags.Instance);
Console.WriteLine($"Method return type: {methodInfo.ReturnType}");

var result = (string) methodInfo.Invoke(myClass, new object[] { first, last });
Console.WriteLine(result);