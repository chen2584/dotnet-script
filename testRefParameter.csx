public void Sum(ref int result)
{
    Console.WriteLine(result);
    result = 55555;
}
int result = 1111;
Sum(ref result);
Console.WriteLine($"Result is {result}");
