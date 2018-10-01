[Flags]
public enum MyColors
{
    Yellow ,
    Green,
    Red ,
    Blue
}

var colors = MyColors.Blue | MyColors.Red;

Console.WriteLine($"colors has Blue {colors.HasFlag(MyColors.Blue)} Values: {MyColors.Blue}");
Console.WriteLine($"colors has Red {colors.HasFlag(MyColors.Red)} Values: {MyColors.Red}");
Console.WriteLine($"colors has Yellow {colors.HasFlag(MyColors.Yellow)} Values: {MyColors.Yellow}");
Console.WriteLine($"colors has Green {colors.HasFlag(MyColors.Green)} Values: {MyColors.Green}");

/*foreach (var suit in Enum.GetValues(typeof(MyColors)))
{
    System.Console.WriteLine(suit.ToString());
}*/