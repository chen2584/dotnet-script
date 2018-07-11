#! "netcoreapp2.1"

var shops = new [] { 
    new { Shop = "Shop A", Products = new [] { "Book", "Pencil", "Rubber" } },
    new { Shop = "Shop B", Products = new [] { "Shirt", "Shoe", "Skirt", "Sock" } },
    new { Shop = "Shop C", Products = new [] { "Apple", "Banana", "Orange", "Grape" } }
};
var result = shops.SelectMany(x => x.Products);
var answer = string.Join(", ", result);
Console.WriteLine($"T4: {answer}");