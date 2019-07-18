enum ActionType
{
    Add,
    Edit,
    Delete
}

var dic = new Dictionary<ActionType, int>();

if(!dic.ContainsKey(ActionType.Add)) dic[ActionType.Add] = 0;
dic[ActionType.Add]++;
Console.WriteLine(dic[ActionType.Add]); // return 1