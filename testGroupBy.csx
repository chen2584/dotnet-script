public class Person
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public int Age { get; set; }
}

var personList = new List<Person>()
{
    new Person() { Id = 1, FullName = "Chen Angelo", Age = 20 },
    new Person() { Id = 1, FullName = "Chen Angelo", Age = 20 },
    new Person() { Id = 2, FullName = "Chen Angelo", Age = 25 }
};

var result = personList.GroupBy(x => new { x.Id, x.FullName }).Select(x => x.FirstOrDefault()).ToList();

Console.WriteLine($"{result.Count()}");;
foreach (var value in result)
{
    Console.WriteLine($"Id: {value.Id}, FullName: {value.FullName}, Age: {value.Age}");
}