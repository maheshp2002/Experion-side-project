using projectName;

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


var Stu = new Student()
{
    Name = "Mac",
    Email = "mac@mac.com",
    Dob = DateOnly.Parse(Console.ReadLine())
};

Stu.studentDetails();


