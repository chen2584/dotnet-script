public Task<string> TestTaskCompletionSource()
{
    var tcs = new TaskCompletionSource<string>();
    var task = Task.Run(async () =>
    {
        await Task.Delay(5000);
        tcs.TrySetResult("Hello World!");
    });
    Console.WriteLine("This line should appear before 'Hello World!'");
    return tcs.Task;
}

Console.WriteLine("Invoking Test TaskCompletionSource...");
var result = await TestTaskCompletionSource();
Console.WriteLine(result);