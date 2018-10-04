using System.Reflection;

class MyClass
{
    private string PrintHello(string name)
    {
        return $"Hello World {name}";
    }
}

var name = "Chen Angelo";
var myClass = new MyClass();

// If Method is not defined, methodInfo will be null
var methodInfo = myClass.GetType().GetMethod("PrintHello", BindingFlags.NonPublic | BindingFlags.Instance);
Console.WriteLine($"Method return type: {methodInfo.ReturnType}");

var result = (string) methodInfo.Invoke(myClass, new object[] { name });
Console.WriteLine(result);