private Task<string> TestExceptionAsync()
{
    Console.WriteLine("Executing TestExceptionAsync");

    int num1 = 0;
    int num2 = 5 / num1;
    Console.WriteLine("Divide is " + num2);

    return Task.FromResult("Chen Numba one");
}

var result = TestExceptionAsync();
await Task.WhenAll(result);
Console.WriteLine($"Result is {result.Result}");