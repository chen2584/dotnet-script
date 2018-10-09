public bool RunTheMethod(Func<string, string> myMethodName)
{
    Console.WriteLine(myMethodName("Hello RunTheMethod"));
    return true;
}

RunTheMethod(x => x);
