#! "netcoreapp2.1"
#r "nuget: Microsoft.Extensions.DependencyInjection, 2.1.1"

using Microsoft.Extensions.DependencyInjection;

public class MyClass
{
    private string guid;
    public MyClass()
    {
        guid = Guid.NewGuid().ToString();
    }
    public void ShowGuid()
    {
        Console.WriteLine(guid);
    }
}

var serviceProvider = new ServiceCollection()
    .AddTransient<MyClass>()
    .BuildServiceProvider();

var myService1 = serviceProvider.GetService<MyClass>();
var myService2 = serviceProvider.GetService<MyClass>();

myService1.ShowGuid();
myService2.ShowGuid();