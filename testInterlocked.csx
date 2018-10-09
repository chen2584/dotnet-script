using System.Threading;

int num = 0;
Interlocked.Add(ref num, 5);
Interlocked.Exchange(ref num, 10);
Console.WriteLine($"num is {num}");

long num2 = Interlocked.CompareExchange(ref num, 20, 10); // CompareExchange: if 10, change to 20.
Console.WriteLine($"num is {num}, num2 is {num2}");