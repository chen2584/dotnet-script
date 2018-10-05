try
{
    var num1 = 10;
    var num2 = 0;
    var result = num1 / num2;
}
catch (DivideByZeroException ex)
{
    Console.WriteLine(ex.ToString());
    Console.WriteLine("DivideByZero");
}
catch (Exception) // This one will not reach
{
    Console.WriteLine("Exception");
}