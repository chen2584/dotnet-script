var pattern = "1/2/3/4";
var dict = new Dictionary<string, string>
{
    ["1"] = "Number1",
    ["2"] = "Number2",
    ["3"] = "Number3",
    ["4"] = "Number4"
};
var result = dict.Aggregate(pattern, (p, kv) => p.Replace(kv.Key, kv.Value));
Console.WriteLine(result);