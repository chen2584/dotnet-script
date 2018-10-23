class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
}


var list1 = new List<Person> {
    new Person { FirstName = "Chen1", LastName = "Angeolo1", Age = 14 },
    new Person { FirstName = "Chen2", LastName = "Angelo2", Age = 20 }
};

var dictionary = list1.ToDictionary(x => x.FirstName, x => x);

foreach (var value in dictionary)
{
    Console.WriteLine($"Key: {value.Key}, Value: {value.Value.FirstName}. {value.Value.LastName}");
}