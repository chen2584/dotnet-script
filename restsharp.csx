#! "netcoreapp2.1"
#r "nuget: NetStandard.Library, 2.0.3"
#r "nuget: RestSharp, 106.3.1"

using RestSharp;

var client = new RestClient("https://jsonplaceholder.typicode.com/posts/1");
var request = new RestRequest(Method.GET);
IRestResponse response = client.Execute(request);
var content = response.Content; // raw content as string
Console.WriteLine(content);