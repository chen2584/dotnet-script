
public static bool IsNullOrEmptyOrWhitespace(this string str)
{
    return (String.IsNullOrEmpty(str) || str.Trim().Length == 0);
}


var str = "  c ";
Console.WriteLine($"str is null or empty?: {str.IsNullOrEmptyOrWhitespace()}");