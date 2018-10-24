class Person
{
    public string FullName { get; set; }
    public int Age { get; set; }
    public string DepartmentName { get; set; }
}

public class Department
{
    public int Id { get; set; }
    public string DepartmentName { get; set; }
}

var personList = new List<Person>
{
    new Person { FullName = "Chen Angelo1", Age = 20, DepartmentName = "IT" },
    new Person { FullName = "Chen Angelo2", Age = 20, DepartmentName = "HR" },
    new Person { FullName = "Chen Angelo3", Age = 20, DepartmentName = "IT" },
    new Person { FullName = "Chen Angelo4", Age = 20, DepartmentName = "IT" }
};

var departmentList = new List<Department>
{
    new Department { Id = 1, DepartmentName = "IT"},
    new Department { Id = 2, DepartmentName = "HR"},
    new Department { Id = 3, DepartmentName = "IT"}
};

var result = (from p in personList
              join d in departmentList on p.DepartmentName equals d.DepartmentName into eGroup select new { Person = p, DepartmentName = eGroup.Count()});

foreach (var value in result)
{
    Console.WriteLine($"{value.Person.FullName}, {value.DepartmentName}");
}

    