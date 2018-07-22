#! "netcoreapp2.1"

using System.Threading;

public class TestClass
{
    /*
    // These two may throw an error DevideByZero because not ThreadSafe
    public int num1;
    public int num2;
    */

    Random o = new Random();
    public void TestThreadSafe()
    {
        Console.WriteLine("Enter Loop");
        for(int i = 0; i < 1000000; i++)
        {
            
            int num1 = o.Next(1, 2);
            int num2 = o.Next(1, 2);
            int result = num1/num2;
            num1 = 0;
            num2 = 0;
        }
    }
}

TestClass testClass = new TestClass();
Thread thread = new Thread(testClass.TestThreadSafe);
thread.Start();
testClass.TestThreadSafe();
