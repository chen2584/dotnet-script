public class MyClass
{
    public event EventHandler OnMultipleOfTwo;
    public int Sum(int num1, int num2)
    {
        var result = num1 + num2;
        if (result % 2 == 0 && OnMultipleOfTwo != null)
        {
            OnMultipleOfTwo(this, EventArgs.Empty);
        }
        return result;
    }
}

static void MultipleOfFiveReached(object sender, EventArgs e)
{
    Console.WriteLine("MultipleOfFiveReached");
}

var myClass = new MyClass();
myClass.OnMultipleOfTwo += MultipleOfFiveReached;

Console.WriteLine($"1 + 4 = {myClass.Sum(1, 4)}");
Console.WriteLine($"2 + 2 = {myClass.Sum(2, 2)}");