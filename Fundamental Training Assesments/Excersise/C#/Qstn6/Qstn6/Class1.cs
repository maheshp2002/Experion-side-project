Console.WriteLine("Enter the string");
string str = Console.ReadLine();

char[] arr = new char[str!.Length];

Console.WriteLine("Enter the char you need to change");

char change = char.Parse(Console.ReadLine());

Console.WriteLine("Enter the new character");
char NewChar = char.Parse(Console.ReadLine());

for (int i = 0; i < str.Length; i++)
{
	arr[i] = str[i];
}

for (int i = 0; i < arr.Length; i++)
{
	if (arr[i] == change)
	{
		arr[i] = NewChar;
	}
}

Console.WriteLine(string.Join("",arr));
