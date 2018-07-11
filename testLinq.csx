#! "netcoreapp2.1"

class Name
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

List<Name> nameList = new List<Name>();
nameList.Add(new Name() { FirstName = "Chen", LastName = "Angelo" });
nameList.Add(new Name() { FirstName = "Elon", LastName = "Musk" });

var result = nameList.Select(x => $"{x.FirstName} {x.LastName}");

foreach(string fullname in result)
{
    Console.WriteLine(fullname);
}