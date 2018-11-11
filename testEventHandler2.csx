public class MultipleOfTwoEventArgs : EventArgs
{
    public int Total { get; set; }
    public MultipleOfTwoEventArgs(int total)
    {
        Total = total;
    }
}

public class MyClass
{
    public event EventHandler<MultipleOfTwoEventArgs> MultipleOfTwoEventArgs;
    public int Sum(int num1, int num2)
    {
        var result = num1 + num2;
        if (result % 2 == 0 && MultipleOfTwoEventArgs != null)
        {
            MultipleOfTwoEventArgs(this, new MultipleOfTwoEventArgs(result));
        }
        return result;
    }
}

static void OnMultipleOfTwoReached(object sender, MultipleOfTwoEventArgs e)
{
    Console.WriteLine($"OnMultipleOfTwoReached: {e.Total}");
}

var myClass = new MyClass();
myClass.MultipleOfTwoEventArgs += OnMultipleOfTwoReached;
Console.WriteLine($"1 + 2 = {myClass.Sum(1, 2)}");
Console.WriteLine($"2 + 2 = {myClass.Sum(2, 2)}");
