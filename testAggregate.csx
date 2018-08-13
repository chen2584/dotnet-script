using System.Numerics;

var numbers = Enumerable.Range(1, 20);

var result = numbers.Aggregate(BigInteger.One, (workingNumber, next) => workingNumber * next);
Console.WriteLine($"Result is {result}");