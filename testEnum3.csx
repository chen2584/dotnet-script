public enum Department
{
    Test1,
    Test2,
    Test3
}

var list = new List<Department>();
Console.WriteLine($"First Enum is: {list.FirstOrDefault().ToString()}"); ; // return Test1