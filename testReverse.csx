#! "netcoreapp2.1"

string value = "This is a book";
var result = String.Join(" ", value
    .Split(" ")
    .Select(x => new String(x.Reverse().ToArray())));

Console.WriteLine(result);