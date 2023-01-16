int[] fareArray = new int[10];

// sorting

// input array
Console.WriteLine("\r\t<----------Input Data---------->\r\t");

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Enter fare\t" + i);
    fareArray[i] = int.Parse(Console.ReadLine());
}

// output sorted array
Console.WriteLine("\r\t<----------Sort Order---------->\r\t");

Console.WriteLine("After sort\n");
Array.Sort(fareArray);

foreach (int g in fareArray)
{
    Console.WriteLine(g);
}

//int[] fareArray2 = new int[10];

Console.WriteLine("\r\t<----------Reverse Order---------->\r\t");

// output in reverse order
for (int i = fareArray.Length - 1; i >= 0; i--)
{
    Console.WriteLine(fareArray[i]);
}

Console.WriteLine("\r\t<----------Search Order---------->\r\t");
int searchInput = int.Parse(Console.ReadLine());
int searchResult = Array.Find(fareArray, element => element == searchInput);

if (searchResult != null)
{
    Console.WriteLine($"Search result found {searchResult}");
    //{ Array.IndexOf(fareArray, searchInput)}

}
else
{
    Console.WriteLine("Not found");
}

Console.WriteLine("\r\t<----------Print min and max---------->\r\t");
Console.WriteLine($"Max value is {fareArray.Max()}");
Console.WriteLine($"Min value is {fareArray.Min()}");



Console.WriteLine("\r\t<----------Print duplicate entries---------->\r\t");

for (int i = 0; i < fareArray.Length; i++)
{
    for (int j = i + 1; j < fareArray.Length; j++)
    {
        if (fareArray[i] == fareArray[j])
        {
            Console.WriteLine($"Duplicate data is {fareArray[i]}");
        }
    }
}