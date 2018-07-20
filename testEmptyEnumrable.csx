#! "netcoreapp2.1"

// enumrable.empty is struct
var enum1 = Enumerable.Empty<string>();
var enum2 = Enumerable.Empty<string>();

Console.WriteLine(Object.ReferenceEquals(enum1, enum2));
Console.WriteLine($"enum1 hashcode: {enum1.GetHashCode()}, enum2 hashcode: {enum2.GetHashCode()}");