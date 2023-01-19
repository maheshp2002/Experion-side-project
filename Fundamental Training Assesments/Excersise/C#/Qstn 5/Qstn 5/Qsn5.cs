Console.WriteLine("Enter the array limit");

int length = int.Parse(Console.ReadLine());

decimal[] temp = new decimal[length];
decimal[] arr = new decimal[length * 2];

Console.WriteLine("Enter the number");

for (int i = 0; i < temp.Length; i++)
{
    temp[i] = decimal.Parse(Console.ReadLine());       
}

int k = 2;
int l = 1;
for (int j = 0; j < temp.Length; j++)
{
    if(temp[j] % 2 == 0)
    {
        arr[k] = temp[j];
        k += 2;
    } else
    {
        arr[l] = temp[j];
        l += 2;
    }
}

Console.WriteLine($"\r\n{string.Join(",", arr)}");

//foreach (var item in arr)
//{
//    Console.WriteLine(item);
//}



