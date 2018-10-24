public class Person : IEquatable<Person>
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public int Age { get; set; }
    public bool Equals(Person person)
    {
        Console.WriteLine("Equals person");
        return (this.FullName.Equals(person.FullName) && this.Age == this.Age);
    }

    public override int GetHashCode()
    {
        return 1;
    }
}

var personList = new List<Person>()
{
    new Person() { Id = 1, FullName = "Chen Angelo", Age = 20 },
    new Person() { Id = 1, FullName = "Chen Angelo", Age = 20 }
};

var result = personList.Distinct().ToList();

Console.WriteLine($"Found {result.Count}");