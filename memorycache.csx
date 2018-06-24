#! "netcoreapp2.1"
#r "nuget: System.Runtime.Caching, 4.5.0"
#r "nuget: Microsoft.Extensions.Caching.Memory, 2.1.1"

using Microsoft.Extensions.Caching.Memory;
MemoryCache cache = new MemoryCache(new MemoryCacheOptions());
var cacheEntryOptions = new MemoryCacheEntryOptions().SetAbsoluteExpiration(TimeSpan.FromSeconds(30));
cache.Set("key1", "Chen Angelo");

cache.Set("key2", "Alexander", cacheEntryOptions);
Console.WriteLine($"Total Cache {cache.Count}");