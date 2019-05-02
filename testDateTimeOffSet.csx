DateTime date1, date2;
DateTimeOffset dateOffset1, dateOffset2;
TimeSpan difference;

// Find difference between Date.Now and Date.UtcNow
date1 = DateTime.Now;
date2 = DateTime.UtcNow;
difference = date1 - date2;
Console.WriteLine("{0} - {1} = {2}", date1, date2, difference);

// Find difference between Now and UtcNow using DateTimeOffset
dateOffset1 = DateTimeOffset.Now.DateTime;
var chen = DateTimeOffset.Now.DateTime;
dateOffset2 = DateTimeOffset.UtcNow;
difference = dateOffset1 - dateOffset2;
Console.WriteLine("{0} - {1} = {2}",
                  dateOffset1, dateOffset2, difference);
var timezone = TimeZoneInfo.FindSystemTimeZoneById("Japan");
var japanTime = TimeZoneInfo.ConvertTime(dateOffset1, timezone);
Console.WriteLine(japanTime.ToString());
// If run in the Pacific Standard time zone on 4/2/2007, the example
// displays the following output to the console:
//    4/2/2007 7:23:57 PM - 4/3/2007 2:23:57 AM = -07:00:00
//    4/2/2007 7:23:57 PM -07:00 - 4/3/2007 2:23:57 AM +00:00 = 00:00:00