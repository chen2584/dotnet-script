public class MyClass
{
    public int[] numList = new int[] { 1, 2, 3, 4, 5, 6 };
    public void Run()
    {
        ref int num = ref numList[0];
        num = 5555;
        Console.WriteLine(String.Join(", ", numList));
    }
}

MyClass myClass = new MyClass();
myClass.Run();