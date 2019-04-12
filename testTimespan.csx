TimeSpan timeSpan = TimeSpan.FromMilliseconds(100000);
Console.WriteLine(timeSpan);

TimeSpan timeSpan2 = TimeSpan.FromMilliseconds(0);
Console.WriteLine(timeSpan2 == default(TimeSpan));

double Timeout;
Console.WriteLine(Timeout);