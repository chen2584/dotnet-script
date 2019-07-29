class MyParentClass
{
    static MyParentClass()
    {
        Console.WriteLine("Hello from Static Parent class");
    }

    public MyParentClass()
    {
        Console.WriteLine("Hello from Instance Parent class");
    }
}

class MyClass : MyParentClass
{
    public static string name { get; set; } = "Chen";
    static MyClass()
    {
        Console.WriteLine("Hello from static MyClass");
    }

    public MyClass()
    {
        Console.WriteLine("Hello from Instance MyClass");
    }

    public void PrintHello()
    {
        Console.WriteLine("Hello World!");
    }
}

// Console.WriteLine(MyClass.name);
var myClass = new MyClass();
myClass.PrintHello();

// output:
// Hello from static MyClass
// Hello from Static Parent class
// Hello from Instance Parent class
// Hello from Instance MyClass
// Hello World!