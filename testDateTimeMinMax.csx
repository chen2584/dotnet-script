var dateTimeList = new List<DateTime?>
{
    DateTime.Now,
    DateTime.Now.AddDays(1),
    null
};

var minDateTime = dateTimeList.Where(x => x.HasValue).Min();
var maxDateTime = dateTimeList.Where(x => x.HasValue).Max();

Console.WriteLine($"{minDateTime} : {maxDateTime}"); // 16/07/2019 13:48:00 : 17/07/2019 13:48:00