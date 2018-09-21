void DoSomething(int i)
{
    Console.WriteLine(i);
}

Action<int> action = new Action<int>(DoSomething);
action(5555);