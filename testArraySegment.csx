#! "netcoreapp2.1"

void Print(ArraySegment<byte> data)
{
    Console.WriteLine(string.Join(", ", data));
}

var array = new byte[] { 5, 8, 9, 20, 70, 44, 2, 4 };
var segment = new ArraySegment<byte>(array, 2, 3);
Print(segment); // output: 9, 20, 70
Console.WriteLine(String.Join(", ", segment.Reverse())); // output 70, 20, 9
Print(segment); // No change