short num = 0;

for(int i=0; i < 99999; i++)
{
    checked // throw exception if num overflow.
    {
        num++;
    }
    unchecked // Default Value
    {
        num++;
    }
}

Console.WriteLine($"Task Complete. num is {num}");