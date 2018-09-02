struct User
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age; // This will not in GetProperties
}

var user = new User() { FirstName = "Chen", LastName = "Angelo", Age = 14 };
var properties = user.GetType().GetProperties();

foreach(var property in properties)
{
    Console.WriteLine($"{property.Name} = {property.GetValue(user)}");
}

Console.WriteLine($"Outside GetProperties Age: {user.Age}");