using System.Threading;

var timer = new Timer(x => {
    Console.WriteLine("Hello World");
}, null, TimeSpan.Zero, TimeSpan.FromSeconds(1));

Console.WriteLine("Press any key to exit...");
Console.ReadLine();