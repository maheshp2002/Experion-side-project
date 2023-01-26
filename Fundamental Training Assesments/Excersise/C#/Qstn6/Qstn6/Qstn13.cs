using System.Collections;

ArrayList DynamicArray = new ArrayList();
bool IsQuit = true;
while (IsQuit)
{
    Console.WriteLine("1. Add flight number");
    Console.WriteLine("2. Quit");

    var value = Console.ReadLine();

    switch (value)
    {
        case "1":
            AddFlightNumber();
            break;
        case "2":
            IsQuit= false;
            foreach (var v in DynamicArray) Console.WriteLine($"Flight {v}");
            break;
        default:
            Console.WriteLine("Wrong input");
            break;
    }
}

void AddFlightNumber()
{
   Console.WriteLine("Enter the Flight Number");
   DynamicArray.Add(Console.ReadLine());
}
