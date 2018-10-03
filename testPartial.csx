partial class MyClass
{
    partial void SamplePartialMethod();

    public void PublicMethod()
    {
        Console.WriteLine("PublicMethod Invoked");
        SamplePartialMethod();
    }
}

partial class MyClass
{
    partial void SamplePartialMethod()
    {
        Console.WriteLine("SamplePartialMethod");
    }
}

var myClass = new MyClass();
myClass.PublicMethod();