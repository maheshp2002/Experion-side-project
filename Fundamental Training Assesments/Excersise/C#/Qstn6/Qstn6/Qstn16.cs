var List = new List<Dictionary<string, string>>();


while (true)
{
    Console.WriteLine("1. Add passenger preference");
    Console.WriteLine("2. Sort from first row to last row");
    Console.WriteLine("3. Sort from last row to first row");
    Console.WriteLine("4. Quit");
    var input = Console.ReadLine();

    switch (input)
    {
        case "1":
            AddDetails();
            break;
        case "2":
            SortFToL();
            break;
        case "3":
            SortLToF();
            break;
        case "4":
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Invalid input");
            break;
    }
}


void AddDetails()
{
    for (int i = 0; i < 10; i++)
    {
        var dict = new Dictionary<string, string>();

        Console.WriteLine($"{i + 1}. Enter passenger seat number.");
        dict["seat"] = Console.ReadLine();  

        Console.WriteLine($"{i + 1}. Enter passenger name.");
        dict["name"] = Console.ReadLine();

        List.Add(dict);
    }
}
void SortFToL()
{
    Sort();
    foreach (var item in List)
    {
        Console.WriteLine($"\r\n seat_no: {item["seat"]}    |  Name: {item["name"]}");
    }
}
void SortLToF()
{
    Sort();
    for (int i = List.Count - 1; i >= 0; i--)
    {
        Console.WriteLine($"\r\n seat_no: {List[i]["seat"]}  |   Name: {List[i]["name"]}");
    }
}

void Sort()
{
    for (int i = 0; i < List.Count; i++)
    {
        for (int j = 0; j < List.Count; j++)
        {
            if (int.Parse(List[i]["seat"]) < int.Parse(List[j]["seat"]))
            {
                var tempSeat = List[i]["seat"];
                var tempName = List[i]["name"];

                List[i]["seat"] = List[j]["seat"];
                List[i]["name"] = List[j]["name"];

                List[j]["seat"] = tempSeat;
                List[j]["name"] = tempName;
            }
        }
    }
}