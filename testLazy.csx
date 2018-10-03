public sealed class Singleton
{
    private static readonly Lazy<Singleton> _instance = new Lazy<Singleton>(() => new Singleton());
    
    public static Singleton Instance { get { return _instance.Value; } }

    public string guid { get; set; }
    private Singleton()
    {
        guid = Guid.NewGuid().ToString();
    }
}

var singleton = Singleton.Instance;
Console.WriteLine(singleton.guid);

var singleton2 = Singleton.Instance;
Console.WriteLine(singleton2.guid);