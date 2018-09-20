// Instantiate a new 2D string array.
string[,] array = new string[2, 2];
array[0, 0] = "top left";
array[0, 1] = "top right";
array[1, 0] = "bottom left";
array[1, 1] = "bottom right";

Console.WriteLine("Rank: " + array.Rank);

// Get upper bounds for the array
int bound0 = array.GetUpperBound(0);
int bound1 = array.GetUpperBound(1);

// Use for-loops to iterate over the array elements
for (int variable1 = 0; variable1 <= bound0; variable1++)
{
    for (int variable2 = 0; variable2 <= bound1; variable2++)
    {
        string value = array[variable1, variable2];
        Console.WriteLine(value);
    }
}