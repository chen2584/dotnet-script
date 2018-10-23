// ไม่แนะนำให้ใช้
// คนละ reference แน่นอน

class Person : ICloneable
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    public object Clone()
    {
        return new Person { FirstName = this.FirstName, LastName = this.LastName, Age = this.Age };
    }
}


var list1 = new List<Person> {
    new Person { FirstName = "Chen1", LastName = "Angeolo1", Age = 14 },
    new Person { FirstName = "Chen2", LastName = "Angelo2", Age = 20 }
 };

var list2 = list1.Select(x => (Person)x.Clone()).ToList();

Console.WriteLine("List1:");
foreach (var person in list1)
{
    Console.WriteLine($"FirstName: {person.FirstName}, LastName: {person.LastName}, Age: {person.Age}");
}

Console.WriteLine("\nList2:");
foreach (var person in list2)
{
    Console.WriteLine($"FirstName: {person.FirstName}, LastName: {person.LastName}, Age: {person.Age}");
}

Console.WriteLine("\nIndex Equal Test:");
for (var i = 0; i < list1.Count; i++)
{
    Console.WriteLine($"Index1 Equal?: {Object.ReferenceEquals(list1.ElementAt(i), list2.ElementAt(i))}");
}