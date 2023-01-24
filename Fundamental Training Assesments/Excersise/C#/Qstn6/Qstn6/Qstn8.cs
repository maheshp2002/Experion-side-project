decimal[] arr = new decimal[10];
string[] arr2 = new string[10];

for(int i = 0;i < arr.Length; i++)
{
    Console.WriteLine("Enter the fares");
    arr[i] = decimal.Parse(Console.ReadLine());

    Console.WriteLine("Enter the destination");
    arr2[i] = Console.ReadLine();
}

Console.WriteLine("Enter a index number");
int IndexNo = int.Parse(Console.ReadLine());
Console.WriteLine($"Fare is {arr[IndexNo]} and destination is {arr2[IndexNo]}");

