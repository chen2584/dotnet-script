class User
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
}

User user;

Console.WriteLine(user?.Age == 0); // False
Console.WriteLine(user?.Age == null); // True