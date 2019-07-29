
public class MyTestApp
{
    //The Event Handler declaration
    public delegate void EventHandler();

    //The Event declaration
    public event EventHandler MyHandler;

    //The method to call
    public void Hello1()
    {
        Console.WriteLine("Hello World of events!");
    }

    public void Hello2()
    {
        Console.WriteLine("Hello World of events!");
    }

    public void Run()
    {
        MyTestApp TestApp = new MyTestApp();

        //Assign the method to be called when the event is fired
        MyHandler += new EventHandler(TestApp.Hello1);
        MyHandler += new EventHandler(TestApp.Hello2);

        //Firing the event
        if (MyHandler != null)
        {
            Console.WriteLine("Reach Here!");
            MyHandler();
        }
    }
}

MyTestApp TestApp = new MyTestApp();
TestApp.Run();