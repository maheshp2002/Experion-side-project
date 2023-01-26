var FlightRoute = new List<Dictionary<string, string>>();

while (true)
{
    Console.WriteLine("1. Add flight details");
    Console.WriteLine("2. Display details");
    Console.WriteLine("3. Sort by flight");

    string number = Console.ReadLine();

    switch(number)
    {
        case "1":
            FlightInput();
            break;
        case "2":
            DisplayDetails();
            break;
        case "3":
            ShortestDistance();
            break;
        default:
            Console.WriteLine("Wrong input");
            break;
    }
}

void FlightInput()
{
    var Dict = new Dictionary<string, string>();

    Console.WriteLine("Enter the source: ");
    Dict["source"] = Console.ReadLine();

    Console.WriteLine("Enter the destination: ");
    Dict["destination"] = Console.ReadLine();

    Console.WriteLine("Enter the distance: ");
    Dict["distance"] = Console.ReadLine();

    Console.WriteLine("Enter the fare: ");
    Dict["fare"] = Console.ReadLine();

    FlightRoute.Add(Dict);
}

void DisplayDetails()
{
    foreach (var flight in FlightRoute)
    {
        Console.WriteLine($"*******{flight["source"]}*******");
        Console.WriteLine($"Destination: {flight["destination"]}");
        Console.WriteLine($"Distance: {flight["distance"]}");
        Console.WriteLine($"Fare: {flight["fare"]}");
        Console.WriteLine(new string('-', 50));
    }
}

void ShortestDistance()
{
    int[] arr = new int[FlightRoute.Count];
    int[] arr2 = new int[FlightRoute.Count];

    for (int i = 0; i < FlightRoute.Count; i++)
    {
        arr[i] = int.Parse(FlightRoute[i]["distance"]);
        arr2[i] = int.Parse(FlightRoute[i]["fare"]);
    }

    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[i] < arr[j])
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
    }

    for (int i = 0; i < arr2.Length; i++)
    {
        for (int j = i + 1; j < arr2.Length; j++)
        {
            if (arr2[i] < arr2[j])
            {
                int temp = arr2[i];
                arr2[i] = arr2[j];
                arr2[j] = temp;
            }
        }
    }

    Console.WriteLine(string.Join(",", arr));
    Console.WriteLine(string.Join(",", arr2));

    Console.WriteLine($"Shortest distance is {arr.Min()}");
    Console.WriteLine($"Largest distance is {arr.Max()}");

    Console.WriteLine(new string('-', 50));

    Console.WriteLine($"Lowest fare is {arr2.Min()}");
    Console.WriteLine($"Highest fare is {arr2.Max()}");

    Console.WriteLine(new string('-', 50));

    Console.WriteLine($"Lowest fare {arr2.Min()}, and shortest distance {arr.Min()}");
    Console.WriteLine($"Highest fare {arr2.Max()}, and highest distance {arr.Max()}");

    Console.WriteLine(new string('-', 50));

    Console.WriteLine($"Lowest fare {arr2.Min()}, and highest distance {arr.Max()}");
    Console.WriteLine($"Highest fare {arr2.Max()}, and shortest distance {arr.Min()}");
}








