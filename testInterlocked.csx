using System.Threading;

int num = 0;
Interlocked.Add(ref num, 5);
Interlocked.Exchange(ref num, 30);
Console.WriteLine($"num is {num}");