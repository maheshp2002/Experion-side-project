Console.WriteLine("Enter a Alphabet");
var Alphabet = Console.ReadLine().ToUpper();

switch (Alphabet)
{
	case "F":
        IsF();
		break;
    case "W":
        IsW();
        break;
    case "Q":
        IsQ();
        break;
    case "N":
        IsN();
        break;
    case "A":
        isA();
        break;
    default:
		break;
}

void IsF()
{
    int j = 101;
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine($"F{j}");
        j += 2;
    }
}
void IsW()
{
    int j = 100;
    for (int i = 0; i < 6; i++)
    {
        Console.WriteLine($"F{j}");
        j += 2;
    }
}

void IsQ()
{
    int j = 100;
    for (int i = 0; i < 6; i++)
    {
        if (j%2 == 0)
        {
            Console.WriteLine($"F{j}");
        }
        j++;
    }
}

void IsN()
{
    int val1 = 0, val2 = 1, val3;
    int n = 10;
    Console.WriteLine($"N{val1}");
    Console.WriteLine($"N{val2}");

    for (int i = 2; i < n; i++)
    {
        val3 = val1 + val2;
        Console.WriteLine($"N{val3}");
        val1 = val2;
        val2 = val3;
    }
}

void isA(){
    for (int i = 0; i < 11; i++)
    {
        Console.WriteLine($"A{i}");
    }
}