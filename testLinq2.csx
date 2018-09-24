#! "netcoreapp2.1"

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

var personList1 = new List<Person>() { new Person() { Name = "Chen", Age = 20 }, new Person() { Name = "Chen2", Age = 25 } };
var personList2 = personList1.Where(x => x.Name == "Chen");
personList1[0].Name = "Chen3";

foreach(var result in personList2) // This will not show any result.
{
    Console.WriteLine($"result: {result.Name}, {result.Age}");
}