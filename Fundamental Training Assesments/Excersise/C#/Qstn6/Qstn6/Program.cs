//string[] destination = new string[10];
//string[] distance = new string[10];
//int[] fare = new int[10];

//for (int i = 0; i < destination.Length; i++)
//{
//    Console.WriteLine($"Enter the destination {i}");
//    destination[i] =  Console.ReadLine();
//}
//for (int j = 0; j < distance.Length; j++)
//{
//    Console.WriteLine($"Enter the distance {j}");
//    distance[j] = Console.ReadLine();
//}

//for (int k = 0; k < fare.Length; k++)
//{
//    Console.WriteLine($"Enter the fare {k}");
//    fare[k] = int.Parse(Console.ReadLine());
//}

//Console.WriteLine("Enter the source");
//string sourceInput = Console.ReadLine();

//Console.WriteLine("Enter the destination");
//string destinationInput = Console.ReadLine();

//Dictionary<int, string> flightDistance = new Dictionary<int, string>();

//for (int i = 0; i < 3; i++)
//{
//    Console.WriteLine($"Enter the {i++} details");

//    Console.WriteLine("Enter the source");
//    string source = Console.ReadLine();

//    Console.WriteLine("Enter the destination");
//    string destination = Console.ReadLine();

//    Console.WriteLine("Enter the distance");
//    int distance = int.Parse(Console.ReadLine());

//    Console.WriteLine("Enter the fare");
//    int fare = int.Parse(Console.ReadLine());

//    flightDistance.Add(i++, $"{source}, {destination}, {distance}, {fare}");

//}
//Console.WriteLine(flightDistance[1]);

//string[] arr = flightDistance[1].Split(',');

//for (int j = 0; j < arr.Length; j++)
//{
//    if (arr[j] < '0')
//    {

//    }
//}

//Console.WriteLine(string.Join(" -> ", flightDistance));

var FlightRoute = new List<Dictionary<string, string>>();

while (true)
{
    Console.WriteLine("1. Add flight details");
    Console.WriteLine("1. Sort by shortest flight distance");

    string number = Console.ReadLine();

    switch(number)
    {
        case "1":
            flightInput();
            break;
        case "2":

            break;
        default:
            Console.WriteLine("Wrong input");
            break;
    }
}

void flightInput()
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



