string a = "a";
string b = "b";

int c = string.Compare(a, b);
Console.WriteLine(c);

c = string.CompareOrdinal(b, a);
Console.WriteLine(c);

c = a.CompareTo(b);
 Console.WriteLine(c);

c = b.CompareTo(a);
Console.WriteLine(c);