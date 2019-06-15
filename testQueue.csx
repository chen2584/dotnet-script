using System.Collections.Concurrent;
using System.Threading;

static long _total;
static ConcurrentQueue<int> _queued;

static void Run()
{
    IEnumerable<int> numbers = Enumerable.Range(1, 1000000);
    _queued = new ConcurrentQueue<int>(numbers);
    _total = 0;

    Task task1 = Task.Run(() => ProcessQueue());
    Task task2 = Task.Run(() => ProcessQueue());

    Task.WaitAll(task1, task2);

    Console.WriteLine("Total: {0}", _total);
}

static void ProcessQueue()
{
    int value;

    while (_queued.TryDequeue(out value))
    {
        Interlocked.Add(ref _total, value);
    }
}

Run();