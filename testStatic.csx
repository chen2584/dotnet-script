class MyClass
{
    public static string name { get; set; } = "Chen";
    static MyClass()
    {
        Console.WriteLine(name == null); // false
    }
}

Console.WriteLine(MyClass.name);