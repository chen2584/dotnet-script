try
{
    var num1 = 10;
    var num2 = 0;
    var result = num1 / num2;
    Console.WriteLine("try");
    return;
}
catch(Exception ex)
{
    Console.WriteLine("Catch");
}
finally // program will execute this even exception or not.
{
    Console.WriteLine("Finally");
    Console.WriteLine("Error");
}

// This one will not reach
Console.WriteLine("Ended");