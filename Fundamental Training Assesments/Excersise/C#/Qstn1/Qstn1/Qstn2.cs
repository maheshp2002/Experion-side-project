Console.WriteLine("Enter the time:");
int time = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the rate:");
int rate = int.Parse(Console.ReadLine());

//double temp;

if (time >= 6 && time < 9)
{
    Console.WriteLine(rate + (rate * 0.1));
} 
else if (time >= 9 && time < 17)
{
    Console.WriteLine(rate + (rate * 0.2));
}
else if (time >= 17 && time < 23)
{
    Console.WriteLine(rate + (rate * 0.07));
}
else
{
    Console.WriteLine(rate + (rate * 0.05));
}