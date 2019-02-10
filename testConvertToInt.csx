var str = "009001";
Console.WriteLine($"{str} ConvertToInt: {Convert.ToInt32(str)}"); // output 9001

var str2 = "009";
Console.WriteLine($"{str2} ConvertToInt: {Convert.ToInt32(str2)}"); // output 9

var num = 9;
Console.WriteLine($"{num} ToString 3 digits: {num.ToString("000")}"); // output 009 (string)