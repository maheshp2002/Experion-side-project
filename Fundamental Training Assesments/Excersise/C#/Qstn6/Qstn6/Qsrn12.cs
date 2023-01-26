var Temp1 = new string[10];
var Temp2 = new string[10];

var PassengerArray = new string[Temp1.Length * 2];


for (int i = 0; i < Temp1.Length; i++)
{
    Console.WriteLine($"Enter passenger name {i}");
    Temp1[i] = Console.ReadLine();
}

for (int j = 0; j < Temp2.Length; j++)
{
    Console.WriteLine($"Enter dstination name {j}");
    Temp2[j] = Console.ReadLine();
}

int l = 0;
int k = 1;

for (int i = 0; i < Temp1.Length - 1; i++)
{
    PassengerArray[l] = Temp1[i];
    l += 2;
}

for (int i = 0; i < Temp2.Length - 1; i++)
{
    PassengerArray[k] = Temp2[i];
    k += 2;
}

Console.WriteLine(string.Join(",", PassengerArray));
