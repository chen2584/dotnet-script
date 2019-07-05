using System.Globalization;
var date = (DateTime?)DateTime.ParseExact("04/07/2535","dd/MM/yyyy", new CultureInfo("th-TH"));

Console.WriteLine(date);