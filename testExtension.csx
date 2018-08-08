public static int ToNumber(this string str)
{
    return Int32.Parse(str);
}

int num = 5;
string str = "5";
int result = num + str.ToNumber();
Console.WriteLine(result);