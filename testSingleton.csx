public sealed class SiteStructure
{
    static readonly SiteStructure _instance = new SiteStructure();
    public static SiteStructure Instance
    {
        get
        {
            return _instance;
        }
    }

    readonly string guid;
    SiteStructure()
    {
        // Initialize.
        guid = Guid.NewGuid().ToString();
    }

    public void PrintGuid()
    {
        Console.WriteLine(guid);
    }
}

var s = SiteStructure.Instance;
s.PrintGuid();
s.PrintGuid();

//var ss = new SiteStructure(); // inaccessible because SiteStructure Struct is private.