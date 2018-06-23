#! "netcoreapp2.1"
//#r "nuget: NetStandard.Library, 2.0.3"

double value = 0/0f;
Console.WriteLine(value.ToString());
Console.WriteLine(Double.IsNaN(value));