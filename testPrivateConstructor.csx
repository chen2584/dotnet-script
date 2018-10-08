public class MyClass
{
    public static MyClass Instance { get; } = new MyClass();
    private MyClass()
    {

    }

    public void PrintHello()
    {
        Console.WriteLine("Hello World");
    }
}

var myClass = MyClass.Instance;
myClass.PrintHello();