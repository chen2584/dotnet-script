#r "nuget: Newtonsoft.Json, 12.0.1"

using Newtonsoft.Json.Linq;

var jObject = new JObject();

jObject.Add("SOC:EIEI", "66666666");
Console.WriteLine(jObject.ToString());