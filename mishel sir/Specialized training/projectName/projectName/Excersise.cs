using projectName;
using System.Runtime.CompilerServices;

//string BeepSound(int time, string email = "default", int number = default)
//{
//    Console.WriteLine("Hear a beep after 1 sec " + email);
//    Thread.Sleep(time);
//    Console.Beep();
//    string message = "Did you hear that sound?";
//    return message;
//}

//string msg1 = BeepSound(1000);
//string msg2 = BeepSound(1000, "lol");
//Console.WriteLine(msg2, msg1);


//string BeepSound2(int time, string email = "default", int number = default)
//{
//    Console.WriteLine("Hear a beep after 1 sec " + email);
//    Thread.Sleep(time);
//    Console.Beep();
//    string message = "Did you hear that sound?";
//    return message;
//}

//string msg3 = BeepSound(1000);
//string msg4 = BeepSound(1000, "lol");
//string msg5 = BeepSound(1000, number: 123);
//Console.WriteLine(msg3, msg4, msg5);

//void Addition(int x, params int[] values)
//{
//    int sum = 0;
//    if (values.Length != 0)
//    {
//        sum = x + values[0];
//    } else
//    {
//        sum += x;
//    }
//    Console.WriteLine(sum);
//}
//Addition(1000, 100);
//Addition(1000);

//Using Array

//void Addition(int x, int y, int[] values)
//{
//    int sum = x + y;
//    foreach (int i in values)
//    {
//        sum += i;
//    }
//    Console.WriteLine(sum);
//}
//Addition(1, 2, new int[] {3, 4, 5});

// Obejct Oriented Programming

//var s = new Student();
//s.Name = "Mac";
//s.Mark1 = 30;
//s.Mark2 = 40;

//Console.WriteLine(s.Name + " " + s.Total());

//class Student
//{
//    public string Name;
//    public int Mark1;
//    public int Mark2;
//    public int Total()
//    {
//        return Mark1 + Mark2;
//    }
//}


//better method

//var s = new Student
//{
//    Name = "Mac",
//    Mark1 = 30,
//    Mark2 = 40
//};

//Console.WriteLine(s.Name + " " + s.Total());

//class Student
//{
//    public string Name;
//    public int Mark1;
//    public int Mark2;
//    public int Total()
//    {
//        return Mark1 + Mark2;
//    }
//}

//var p = new Person();
//p.Name = "john";
//p.Mark1 = 30;
//p.Mark2 = 40;
//Console.WriteLine(p.Name);

//var t = new Teacher();
//t.TeacherName = "Mac";
//t.TeacherAge = 10;
//t.AssignTeacherId();

//Console.WriteLine(t.TeacherDetails());

//t.TeacherName = "Viji";
//t.TeacherAge = 100;
//t.AssignTeacherId();

//Console.WriteLine(t.TeacherDetails());

//Console.WriteLine("Enter the string");
//string s = Console.ReadLine();
//int count = 0;
//foreach (var item in s)
//{
//    if (item >= '0' && item <= '9')
//    {
//        count++;
//    }
//}

//if(count == 0)
//{
//    Console.WriteLine("No number found");
//    Environment.Exit(0);
//}

//var numbers = new int[count];
//int arrIndex = 0;
//foreach(var item in s)
//{
//    if (item >= '0' && item <= '9')
//    {
//    numbers[arrIndex++] = int.Parse(item.ToString());
//    }
//}

//Console.WriteLine(string.Join(',', numbers));

//Console.WriteLine("Enter a text");
//string text = Console.ReadLine();

//var number = text.Where(m => m >= '0' && m <= '9')
//    .Select(m =>int.Parse(m.ToString()))
//    .ToArray();
//Console.WriteLine(string.Join(',', numbers));


//var dt = new DateTime(2002, 09, 07);
//Console.WriteLine(dt.DayOfWeek);


//DateTime td = DateTime.Now;
//Console.WriteLine(td);

//TimeSpan ts = td - dt;
//Console.WriteLine(ts.TotalDays);
//Console.WriteLine(ts.TotalHours);
//Console.WriteLine(ts.TotalMinutes);
//Console.WriteLine(ts.TotalSeconds);


// 20-01-2023

//var Stu = new Student()
//{
//    Name = "Mac",
//    Email = "mac@gmail.com",
//    Mark1 = 20,
//    Mark2 = 40,
//    Dob = DateOnly.Parse(Console.ReadLine()),
//    Age= 10,
//};

//Console.WriteLine(Stu.StudentDetails);
//Console.WriteLine(Stu);

//var lst = new List<string>();
//lst.Add("0");
//lst.Add("1");
//lst.Add("2");
//lst.Add("3");


//for (int i = 0; i < 3; i++)
//{
//    Console.WriteLine("Enter name:");
//    lst.Add(Console.ReadLine());
//}
//Console.WriteLine(lst.Count);

//lst.Clear();

//lst.Remove(Console.ReadLine());
//lst.RemoveAt(1);

//var dict = new Dictionary<string, string>();
//dict.Add("macan@mac.com", "Macan");
//dict.Add("lolan@lolan.com", "Lolan");
//dict["viji@gmail.com"] = "Viji";

//Console.WriteLine(dict.Count);
//Console.WriteLine(dict["macan@mac.com"]);

//foreach (var item in dict)
//{
//    Console.WriteLine(item.Key + ":" + item.Value);
//}

////Replace data
//dict["viji@gmail.com"] = "Vijitha";


//foreach (var item in dict)
//{
//    Console.WriteLine(item.Key + ":" + item.Value);
//}

//var employees = new List<Dictionary<string, string>>();

//while (true)
//{
//    Console.WriteLine(" 1. Add Employee");
//    Console.WriteLine(" 2. View Employee");

//    var choice = Console.ReadLine();

//    switch (choice)
//    {
//        case "1":
//            AddEmployee();
//            break;
//        case "2":
//            DisplayEmployee();
//            break;
//        default:
//            Console.WriteLine("Enter employee");
//            break;
//    }
//}

//void AddEmployee()
//{
//    var dict = new Dictionary<string, string>();

//    Console.WriteLine("Enter the name: ");
//    dict["Name"] = Console.ReadLine();

//    Console.WriteLine("Enter the age: ");
//    dict["Age"] = Console.ReadLine();

//    employees.Add(dict);
//}

//void DisplayEmployee()
//{
//    foreach (var employee in employees)
//    {
//        Console.WriteLine($"*******{employee["Name"]}*******");
//        Console.WriteLine($"Age: {employee["Age"]}");
//        Console.WriteLine(new string('-', 50));
//    }
//}

//void Greet() => Console.WriteLine("Hello World");
//int Add(int x, int y) => x + y;

// this is against rule
//Console.WriteLine(Add(1, 2));

//Greet();

//Null coalescing
//string? data = "This is a text";
//var res = data ?? "Default data";
//Console.WriteLine(res);
//Console.WriteLine(data ?? "Default data");

//string? data = null;
//data ??= "Default data";
//Console.WriteLine(data);

//Days Day = Days.Monday;
////or use "var Day = Days.Monday;".
//Console.WriteLine(Day);

//int d = (int)Day;
//Console.WriteLine(d);

//Days day1 = 0;
//Days day2 = (Days)1;

//Console.WriteLine(day1);


//enum Days
//{
//    Monday,
//    Tuesday, 
//    Wednesday,
//}
//string ConvertCasing(string text, Options option)
//{
//    switch (option)
//    {
//        case Options.UpperCase:
//            return text.ToUpper();
//        case Options.LowerCase:
//            return text.ToLower();
//        default:
//            return text;
//    }
//}

//Console.WriteLine(ConvertCasing("Hello", Options.UpperCase)); 
//enum Options
//{
//    UpperCase,
//    LowerCase
//}


////Throw error till you uncomment balance.
//var students = new ArrayClass[5];
//students[0] = new ArrayClass() {Name = "lol" };
//students[1] = new ArrayClass() { Name = "lol" };
////students[2] = new ArrayClass() { Name = "lol" };
////students[3] = new ArrayClass() { Name = "lol" };
////students[4] = new ArrayClass() { Name = "lol" };

//foreach (var item in students)
//{
//    Console.WriteLine(item.Name);
//}

//Console.WriteLine(ArrayClass.ConstName);

//var obj = new ArrayClass("lolan");
//Console.WriteLine(obj.Name);

//var lst = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 12 };
//if ()
//{

//}


//void SayWakeUp() => Console.WriteLine("Wake Up!");

//var alarm1 = new Alarm(15, SayWakeUp);

//MyDelegate caller = SayWakeUp;
//caller();

//delegate void MyDelegate();

//Action 

//void Add(string x, string y, string z)
//{
//    Console.Write(x + y + z);
//}

//Action<string, string, string> caller = Add;
//caller("vi", "ji", "tha");

//string Add2(string x, string y) => x + y;

//Func<string, string, string> caller2 = Add2;
//Console.Write(caller2(" pal", "kuppi"));

//var lst = new List<string> { "vi", "ji", "tha" };

//string? res = lst.Find(n => n == "vi" || n == "Vi");
//Console.Write(res);

//int[] data = { 4, 5, 6, 7 };
////var res1 = data.Any(x => x % 2 == 0);
////Console.WriteLine(res1);
//Console.WriteLine(data.Any(x => x % 2 == 0) ? "yes" : "no");
//Console.WriteLine(data.All(y => y % 2 == 0) ? "yes" : "no");

int[] data = { 3, 4, 5, 6, 7, 8, 9, 11, 4 };
var count = data.Count(m => m <= 5);
Console.WriteLine(count);
var res = data.Take(5);
var res2 = data.TakeLast(5);

var res3 = data.Skip(5);
var res4 = data.SkipLast(5);

var res5 = data.Skip(2).Take(2);

var res6 = data
    .Skip(2)
    .Where(m => m % 2 == 0);

var res7 = data.First(m => m > 5);
var res8 = data.FirstOrDefault(m => m > 50);

int[]? data1 = { 3, 4, 5, 6, 7, 8, 9, 11, 4 };
var res9 = data.FirstOrDefault(m => m > 50);
var res10 = data.LastOrDefault(m => m > 50);
var res11 = res.OrderBy(m => m);
var res12 = res.Reverse();
var res13 = res.TakeWhile(m => m < 10);

var res14 = from i in data where i > 3 select i;

Console.WriteLine(string.Join(",", res));
Console.WriteLine(string.Join(",", res2));
Console.WriteLine(string.Join(",", res3));
Console.WriteLine(string.Join(",", res4));
Console.WriteLine(string.Join(",", res5));
Console.WriteLine(string.Join(",", res6));
Console.WriteLine(string.Join(",", res7));
Console.WriteLine(string.Join(",", res8));
Console.WriteLine(string.Join(",", res9));
Console.WriteLine(string.Join(",", res10));
Console.WriteLine(string.Join(",", res11));
Console.WriteLine(string.Join(",", res12));
Console.WriteLine(string.Join(",", res13));