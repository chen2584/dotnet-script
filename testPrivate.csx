#! "netcoreapp2.1"

internal class Parent
{
    protected string FirstName { get; set; }
    private string LastName { get; set; }
}

public class Child : Parent
{
    public void GetName()
    {
        FirstName = "Chen Angelo";
        Console.WriteLine($"Name is {FirstName}");
    }
}

Child child = new Child();
child.GetName();