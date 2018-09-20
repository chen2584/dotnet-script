string[,] codes = new string[,]
        {
            {"AA", "BB"},
            {"CC", "DD"}
        };

// Get the upper bound.
// ... Use for-loop over rows.
for (int i = 0; i < codes.GetLength(0); i++)
{
    string s1 = codes[i, 0];
    string s2 = codes[i, 1];
    Console.WriteLine("{0}, {1}", s1, s2);
}