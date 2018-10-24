public class Person : IEquatable<Person>
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public int Age { get; set; }
    public bool Equals(Person person)
    {
        Console.WriteLine("Equals person");
        return (Id, FullName, Age) == (person.Id, person.FullName, person.Age);
    }

    public override bool Equals(object obj)
    {
        Console.WriteLine("Equals object");
        return Equals(obj as Person);
    }
}

var personList = new List<Person>()
{
    new Person() { Id = 2, FullName = "Chen Angelo", Age = 20 },
    new Person() { Id = 1, FullName = "Chen Angelo", Age = 20 },
    new Person() { Id = 1, FullName = "Chen Angelo", Age = 20 }
};
var result = personList.Distinct();

Console.WriteLine($"Found {result.Count()}");
