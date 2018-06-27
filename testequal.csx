#! "netcoreapp2.1"
#r "nuget: NetStandard.Library, 2.0.3"

public class Name
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public bool Equals(Name other)
    {
        return this.FirstName == other.FirstName;
    }
    
}
string n = "n";
Name name1 = new Name { FirstName = "Che"+n, LastName = "Angelo" };
Name name2 = new Name { FirstName = "Chen", LastName = "Angelo" };;

Console.WriteLine($"Name Equals?: {name1.Equals(name2)}");

string chen1 = "Chen";
string chen2 = "Chen";
Console.WriteLine(Object.ReferenceEquals(chen1, chen2));