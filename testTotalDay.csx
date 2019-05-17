var date1 = new DateTime(2019, 5, 10);
var date2 = DateTime.Now.Date;
var result = (date2 - date1).TotalDays;
Console.WriteLine(result);