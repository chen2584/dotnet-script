var list = new List<int> { 1, 2, 3 };
Task.Run(() =>
{
    list.Add(4);
    list.Add(5);
    
    Console.WriteLine("Added Success");
});
foreach(var value in list)
{
    await Task.Delay(50);
    Console.WriteLine(value);
}

// result: System.InvalidOperationException: Collection was modified; enumeration operation may not execute.