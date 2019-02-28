using (var reader = new StreamReader("hello.csx"))
{
    while (true)
    {
        string line = reader.ReadLine();
        if (line == null)
        {
            break;
        }
        Console.WriteLine(line); // Use line.
    }
    //Console.WriteLine(reader.ReadToEndAsync());
}