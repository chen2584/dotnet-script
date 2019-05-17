using (var fileStream = File.Open("/Users/chen/MyWork/Dotnet/dotnet-script/test.txt", FileMode.Open))
{
    var reader = new StreamReader(fileStream);
    // fileStream.WriteByte(121);
    // fileStream.WriteByte(127);
    fileStream.Position = 23;
    Console.WriteLine(reader.ReadToEnd()); // start reading from position 23
}