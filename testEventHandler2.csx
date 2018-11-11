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