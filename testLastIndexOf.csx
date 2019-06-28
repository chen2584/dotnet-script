var str = "123/456/789";
var index = str.LastIndexOf("/"); // result: 7

var result = str.Substring(0, index);
Console.WriteLine(result);