class User
{
    public string FullName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
}

class UserGroup<T, K>
{
    public T Key { get; set; }
    public List<K> Values { get; set; }
}

var users = new List<User>
{
    new User { FullName = "Chen", LastName = "Angelo", Age = 14 },
    new User { FullName = "Cark", LastName = "Kent", Age = 25 },
    new User { FullName = "Honda", LastName = "Some LastName", Age = 14 }
};

var groupDatas = new List<UserGroup<int, User>>();
foreach (var user in users)
{
    // var groupData = groupDatas.FirstOrDefault(x => x.Key == user.Age);
    UserGroup<int, User> groupData = null;
    foreach (var datas in groupDatas)
    {
        if (datas.Key == user.Age)
        {
            groupData = datas;
            break;
        }
    }
    if (groupData != null)
    {
        groupData.Values.Add(user);
    }
    else
    {
        groupDatas.Add(new UserGroup<int, User>
        {
            Key = user.Age,
            Values = new List<User> { user }
        });
    }
}

foreach (var groupData in groupDatas)
{
    Console.WriteLine($"Key: {groupData.Key}");
    foreach (var value in groupData.Values)
    {
        Console.WriteLine($"\t- {value.FullName} {value.LastName}, Age: {value.Age}");
    }
}