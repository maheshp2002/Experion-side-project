// different for loop

//int i = 0;
//for (; i < 5; i++)
//{
//    Console.WriteLine(i);
//}

//int j = 0;
//for (; j < 5;)
//{
//    Console.WriteLine(j++);
//}

//int k = 0;
//for(;;)
//{
//    Console.WriteLine(k++);
//    //Console.WriteLine("Viji loli");
//    Console.Beep();
//}

//int i = 0;
//while(i < 5)
//{
//    Console.WriteLine(i++);
//}

//// Endless while loop
//while(true)
//{
//    Console.WriteLine("Infinite loop");
//}

//string number = "ONE";
//switch (number)
//{
//    case "ONE":
//    case "one":
//        Console.WriteLine("Number is One");
//        break;
//    case "TWO":
//    case "two":
//        Console.WriteLine("Number is Two");
//        break;
//    case "THREE":
//    case "three":
//        Console.WriteLine("Number is Three");
//        break;
//    case "FOUR":
//    case "four":
//        Console.WriteLine("Number is Four");
//        break;
//    case "FIVE":
//    case "five":
//        Console.WriteLine("Number is Five");
//        break;
//    default:
//        Console.WriteLine("Nubmber is One, Two, Three, Four or Five"); 
//        break;
//}

//// switch expression

//int number1 = 10;
//string result = number1 switch
//{
//    1 => "Number is 1",
//    2 => "Number is 2",
//    3 => "Number is 3",
//    _ => "Number is 1, 2 or 3"
//};

//Console.WriteLine(result);

//object[] data = { 1, 2.3, 4, "four", "Five", 9.4, true};
//foreach (object item in data)
//{
//    Console.WriteLine(item);
//}

//int sum = 0;
//foreach (object item in data)
//{
//    var typeOfItem = item.GetType();
//	if (typeOfItem == typeof(int))
//	{
//		sum += (int)item;
//	}
//	Console.WriteLine(sum);
//}

//dynamic d = "Hello";
//Console.WriteLine(d.ToUpper());

//Anonymous

//var obj = new
//{
//	name = "Mac Devil",
//	email = "macDevil@gmail.com"
//};

//Console.WriteLine(obj.ToString().Replace("{", "").Replace("}", ""));

//dynamic obj1 = new
//{
//    name = "Mac Devil",
//    email = "macDevil@gmail.com"
//};

//Console.WriteLine(obj1.email);
//string[] arr = {"|", "/", "-", "|", "-","\\"};

//// new assesment
//while (true)
//{
//    foreach (var item in arr)
//	{
//    Thread.Sleep(100);
//    Console.Write($"\r{item}");
//    }    
//}