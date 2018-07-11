#! "netcoreapp2.1"

using System.Threading;
using System.Threading.Tasks;

class Chen
{
    public async void SleepTenSecond()
    {
        Console.WriteLine("Waiting for unlock...");
        lock(this)
        {
            Console.WriteLine("Thread Sleep for 5 seconds...");
            Thread.Sleep(5000);
            Console.WriteLine("Sleep done!");
        }
    }
}

Chen chen = new Chen();
Console.WriteLine("Lock in main method");
Task task = Task.Run(() => chen.SleepTenSecond());
Task task2 = Task.Run(() => chen.SleepTenSecond());

Console.ReadLine();