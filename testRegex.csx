using System.Text.RegularExpressions;

Regex regex = new Regex(@"\{.*?\}");
var collection = regex.Matches("ERC\\{DocumentHelloWorld}\\{eieiei}-{hahahahahaha}");

foreach(Match match in collection)
{
    Console.WriteLine(match.Value);
}