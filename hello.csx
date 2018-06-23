#! "netcoreapp2.1"
#r "nuget: NetStandard.Library, 2.0.3"
#r "nuget: Newtonsoft.Json, 11.0.2"

using Newtonsoft.Json;

struct Name
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Name(string FirstName, string LastName)
    {
        this.FirstName = FirstName;
        this.LastName = LastName;
    }
}

Name name = new Name("Chen", "Angelo");
string result = JsonConvert.SerializeObject(name);
Console.WriteLine(result);