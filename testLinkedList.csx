var linkedList = new LinkedList<string>(new string[] { "1", "2", "3" });
linkedList.AddFirst("0");

var node = linkedList.Find("1");
linkedList.AddAfter(node, "1111");

foreach (var item in linkedList)
{
    Console.WriteLine(item);
}