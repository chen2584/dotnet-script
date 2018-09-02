using System.Text.RegularExpressions;

string str = "ERC\\{DocumentHelloWorld}-Test\\{eieiei}-{hahahahahaha}";
Regex regex = new Regex(@"\{.*?\}");
var collection = regex.Matches(str);

foreach(Match match in collection)
{
    Console.WriteLine(match.Value);
    str = str.Replace(match.Value, "Chen");
    
}

Console.WriteLine("Resule is: " + str);