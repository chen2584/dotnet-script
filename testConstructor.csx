public partial class Client
{
    private string name;
    public Client() : this ("Chen") 
    {
        Console.WriteLine("Constructor without parameter");
    }

    public Client(string name)
    {
        this.name = name;
        Console.WriteLine("Constructor with parameter"); // This will show first
    }

    public void PrintName()
    {
        Console.WriteLine($"My name is {name}");
    }
}

var children = new Client();
children.PrintName();