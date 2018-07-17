#! "netcoreapp2.1"
#r "nuget: Newtonsoft.Json, 11.0.2"

using Newtonsoft.Json;

public class Node
{
    public string Path { get; set; }
    public bool IsFolder { get; set; } = false;
    public List<Node> Nodes { get; set; }

    public Node(string Path)
    {
        this.Path = Path;

        if ((File.GetAttributes(Path) & FileAttributes.Directory) == FileAttributes.Directory)
        {
            IsFolder = true;
            Nodes = new List<Node>();

            var directories = Directory.GetDirectories(Path);
            var files = Directory.GetFiles(Path);

            foreach (var directory in directories)
            {
                Nodes.Add(new Node(directory));
            }
            foreach (var file in files)
            {
                Nodes.Add(new Node(file));
            }
        }
    }

}

Node node = new Node("/Users/chen/MyWork/ReactNative/tourism-mobile-native/ios");
Console.WriteLine(JsonConvert.SerializeObject(node));