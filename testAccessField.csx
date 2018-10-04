
// This will get property too
/*
    Name: firstName Type: System.String
    Name: lastName Type: System.String
    Name: <FirstName>k__BackingField Type: System.String
    Name: <LastName>k__BackingField Type: System.String
    Name: <Age>k__BackingField Type: System.Int32
 */

using System.Reflection;

class MyClass
{
    string firstName;
    string lastName;
    string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
}

var myClass = new MyClass();
var fields = myClass.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
foreach (var field in fields)
{
    Console.WriteLine($"Name: {field.Name} Type: {field.FieldType}");
}