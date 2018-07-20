#! "netcoreapp2.1"

using System.Collections;

class Example : IEnumerable<string>
{
    List<string> _elements;

    public Example(string[] array)
    {
        this._elements = new List<string>(array);
    }

    IEnumerator<string> IEnumerable<string>.GetEnumerator()
    {
        Console.WriteLine("HERE");
        return this._elements.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        Console.WriteLine("GetEnumerator");
        return this._elements.GetEnumerator();
    }
}

Example example = new Example(
            new string[] { "cat", "dog", "bird" });
// The foreach-loop calls the generic GetEnumerator method.
// ... It then uses the List's Enumerator.
foreach (var element in example)
{
    Console.WriteLine(element);
}