String[] namesArray = new string[10];


// sorting

// input array
Console.WriteLine("\r\t<----------Input Data---------->\r\t");

for (int i = 0; i < 5; i++) {
    Console.WriteLine("Enter name\t" + i);
    namesArray[i] = Console.ReadLine();
}

//// output sorted array
//Console.WriteLine("\r\t<----------Sort Order---------->\r\t");

//Console.WriteLine("After sort\n");
//Array.Sort(namesArray);

//foreach(string g in namesArray)
//{
//    Console.WriteLine(g);
//}

////string[] namesArray2 = new string[10];

//Console.WriteLine("\r\t<----------Reverse Order---------->\r\t");

//// output in reverse order
//for(int i = namesArray.Length - 1; i >= 0; i--)
//{
//    Console.WriteLine(namesArray[i]);
//}

//Console.WriteLine("\r\t<----------Search Order---------->\r\t");
//string searchInput = Console.ReadLine();
//string searchResult = Array.Find(namesArray, element => element == searchInput);

//if (searchResult != null)
//{
//    Console.WriteLine($"Search result found {searchResult}");
//    //{ Array.IndexOf(namesArray, searchInput)}

//} else
//{
//    Console.WriteLine("Not found");
//}

//Console.WriteLine("\r\t<----------Length of element---------->\r\t");

//foreach (var item in namesArray)
//{
//    Console.WriteLine(item + " " + item.Length);
//}

//Console.WriteLine("\r\t<----------Split element---------->\r\t");

//foreach (string name in namesArray) 
//{
//    var temp = name?.Split(" ");
//    for (int j = 0; j < temp?.Length; j++)
//    {
//        Console.WriteLine(temp[j]);
//    }
//}

Console.WriteLine("\r\t<----------Print duplicate entries---------->\r\t");

//bool isFound = false;

for (int i = 0; i < namesArray.Length; i++)
{
    for (int j = i + 1; j < namesArray.Length; j++)
    {
        //Console.WriteLine(namesArray[i] + " " + namesArray[j]);
        if (namesArray[i] == namesArray[j])
        {
            //isFound = true;

            Console.WriteLine("mac"+namesArray[i]);
            break;
        }
    }
}

