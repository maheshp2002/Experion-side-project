String[] namesArray = new string[10];


// sorting

// input array
int number = 1;
for(int i = 0; i < 10; i++) {
    Console.WriteLine("Enter name\t" + number);
    namesArray[i] = Console.ReadLine();
    number ++;
}

// output sorted array
Console.WriteLine("After sort\n");
Array.Sort(namesArray);

foreach(string g in namesArray)
{
    Console.WriteLine(g);
}

