#! "netcoreapp2.1"

[AttributeUsage(AttributeTargets.Method|AttributeTargets.Class)]
public class TestAttribute : Attribute
{
    public TestAttribute()
    {
        Console.WriteLine("TestAttribute Constructor");
    }
}

[Test]
public class TestMethod
{
    public TestMethod()
    {
        Console.WriteLine("TestMethod Constructor");
    }
}

TestMethod testMethod = new TestMethod();