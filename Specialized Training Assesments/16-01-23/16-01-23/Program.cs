//Console.WriteLine("Hello mac \r lolan");

//string path = @"C:\Users\mahesh.p\Documents";

//string data = "How do I open a web browser (URL) from my Flutter code?  \r\n\r\nHow to display snackbar infinite duration in a flutter application\r\n\r\nOS Error: A required privilege is not held by the client errno = 1314\r\n\r\nWhat corresponds to Intent in Flutter?\r\n\r\nHow do i make TextButton full width in flutter?";

//string data1 = @"
//How do I open a web browser (URL) from my Flutter code?  

//How to display snackbar infinite duration in a flutter application

//OS Error: A required privilege is not held by the client errno = 1314

//What corresponds to Intent in Flutter?

//How do i make TextButton full width in flutter?";

//Console.WriteLine(data);
//Console.WriteLine(data1);

//byte b = 10; // 8-bit unsigned
//sbyte sb = -12; // 8-bit signed

//short s = 10; // 16-bit signed
//ushort us = 10; // 16-bit unsigned

//int i = 10; // 32-bit signed
//uint ui = 10; // 32-bit unsigned

//float f = 10.0f; // 32-bit signed
//double d = 10.0; // 64-bit unsigned

//decimal dec = 10.0M; // 128-bit floating

//char c = 'A'; // 16-bit unicode character, never use double codes

//string s = "Hello World";
//string sv = @"Hello World";

// Array
//int[] arr = new int[10];

//int[] arr2 = { 1, 2, 3, 4, 5 };

//int[] arr3 = new int[]{ 1, 2, 3, 4, 5 };

//int[] arr4 = new int[5]{ 1, 2, 3, 4, 5 };

//var arr5 = new int[10];

//Console.WriteLine(arr2[2]);

//int[] data = { 1, 2, 3, 4, 5 };

//Console.WriteLine("\r\n<----------Method 1---------->\r\n");


//for (int i = 0; i < data.Length; i++)
//{
//    Console.WriteLine(data[i]);
//}

//Console.WriteLine("\r\n<----------Method 2---------->\r\n");

//foreach (var item in data)
//{
//    Console.WriteLine(item);
//}

//Console.WriteLine("\r\n<----------Method 3---------->\r\n");

//// new method, using join, don't use this in case of large array
//Console.WriteLine(String.Join("->", data));

//Console.WriteLine("\r\n<----------String---------->\r\n");

//string firstName = "Maccuchi";
//string lastName = "Macusubhi";
//int age = 20;

//Console.WriteLine("\r\n<----------String Interpolation---------->\r\n");

//Console.WriteLine($"{firstName} {lastName} aka MacDevil");

//Console.WriteLine("\r\n<----------String Format---------->\r\n");

//Console.WriteLine(string.Format("{0} {1} is {2} year old.", firstName, lastName, age));

//Console.WriteLine("\r\n<----------String format issue---------->\r\n");

//Console.WriteLine(string.Format("{0} {0} is {2} year old.", firstName, lastName, age)); // using same index causes error.

//Console.WriteLine("\r\n<----------String Join---------->\r\n");

//Console.WriteLine(string.Join(" ", firstName, lastName));

//Console.WriteLine("\r\n<----------String Concat---------->\r\n");

//Console.WriteLine(string.Concat(firstName, " ", lastName));

//Console.WriteLine("\r\n<----------String Upper case and lower case---------->\r\n");

//String str = "    Hi I'm a lolan.     ";
//Console.WriteLine(str.ToLower() + " " + str.ToUpper());

//Console.WriteLine("\r\n<----------String trim---------->\r\n");

//Console.WriteLine(str.Trim());
//Console.WriteLine(str.TrimStart());
//Console.WriteLine(str.TrimEnd());

//Console.WriteLine("\r\n<----------String indeOf---------->\r\n");

//Console.WriteLine(str.IndexOf("Hi"));
//Console.WriteLine(str.IndexOf("lolan"));
//Console.WriteLine(str.IndexOf("macan"));

//Console.WriteLine("\r\n<----------String Contains---------->\r\n");
//Console.WriteLine(str.Contains("Macan"));

//Console.WriteLine("\r\n<----------Character array---------->\r\n");
//char[] chars = str.ToCharArray();
//foreach (var item in chars)
//{
//    Console.WriteLine(item);
//}

//Console.WriteLine("\r\n<----------String split---------->\r\n");


//string[] words = str.Split(' ');
//foreach (var item in words)
//{
//    Console.WriteLine(item);
//}

//Console.WriteLine("\r\n<----------String Replace---------->\r\n");

//string data3 = "Hello World";
//data3 = data3.Replace("Hello", "Hi");
//Console.WriteLine(data3);


//string data4 = "Hello World";
//data4 = data4.Remove(0, 5);
//Console.WriteLine(data4);

Console.BackgroundColor = ConsoleColor.White;

String[] str = {"  ", "  " , "  " , "  " , "  " , "  " , "  " , "  " , "  " , "  " };


for (int i = 0;i < str.Length; i++)
{
    Console.Write(str[i]);
}

Console.Write("\r");

for (int i = 0; i < str.Length; i++)
{
    Thread.Sleep(1000);
    //Console.Write(str);
    Console.BackgroundColor = ConsoleColor.Green;
    Console.Write($"{str[i]}");
}





