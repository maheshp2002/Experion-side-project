string[] destination = new string[10];
string[] distance = new string[10];
int[] fare = new int[10];

for (int i = 0; i < destination.Length; i++)
{
    Console.WriteLine($"Enter the destination {i}");
    destination[i] =  Console.ReadLine();
}
for (int j = 0; j < distance.Length; j++)
{
    Console.WriteLine($"Enter the distance {j}");
    distance[j] = Console.ReadLine();
}

for (int k = 0; k < fare.Length; k++)
{
    Console.WriteLine($"Enter the fare {k}");
    fare[k] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Enter the source");
string sourceInput = Console.ReadLine();

Console.WriteLine("Enter the destination");
string destinationInput = Console.ReadLine();


