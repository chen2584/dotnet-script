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
var methodInfo = myClass.GetType().GetMethod("PrintHello", BindingFlags.NonPublic | BindingFlags.Instance);
var result = (string) methodInfo.Invoke(myClass, new object[] { name });
Console.WriteLine(result);