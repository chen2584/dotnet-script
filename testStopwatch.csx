#! "netcoreapp2.1"

using System.Threading;

Stopwatch sw = new Stopwatch();
sw.Restart();
sw.Start();
Thread.Sleep(5555);
sw.Stop();
Console.WriteLine(sw.Elapsed.Duration());

sw.Reset();
sw.Start();
Thread.Sleep(1111);
sw.Stop();
Console.WriteLine(sw.Elapsed.Duration());

Console.WriteLine(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));