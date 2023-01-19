Console.WriteLine("Enter your dob ");
DateTime date = DateTime.Parse(Console.ReadLine());
TimeSpan temp = DateTime.Now - date;
var year = DateTime.Now.Year - date.Year;

Console.WriteLine("Number of Days");
Console.WriteLine(temp.Days);

Console.WriteLine("Number of Hours");
Console.WriteLine(temp.Days * 24);

Console.WriteLine("Number of Months");
Console.WriteLine(year * 12);

Console.WriteLine("Number of Weeks");
Console.WriteLine(temp.Days/7);

Console.WriteLine("Number of Year");
Console.WriteLine(year);