string name;

if(name.Equals("")) // This will throw an exception
{
    Console.WriteLine("name = empty");
}

//Console.WriteLine(name.Equals(""));

Console.WriteLine(name); // This will not
Console.WriteLine("end of application");