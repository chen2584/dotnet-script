#! "netcoreapp2.1"

[AttributeUsage(AttributeTargets.Method|AttributeTargets.Class)]
public class TestAttribute : Attribute
{
    public TestAttribute()
    {
        Console.WriteLine("TestAttribute Constructor");
    }
}

public class TestMethod
{
    public TestMethod()
    {
        Console.WriteLine("TestMethod Constructor");
    }

    [Test]
    public void Test()
    {
        Console.WriteLine("Hello World!");
    }
}

TestMethod testMethod = new TestMethod();
testMethod.Test();