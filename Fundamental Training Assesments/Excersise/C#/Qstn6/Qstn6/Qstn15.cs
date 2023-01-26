int[] weight = new int[10];
var list = new List<Dictionary<string, int>>();


for (int i = 0; i < weight.Length; i++)
{
    Console.WriteLine($"{i + 1}. Enter the weight");
    weight[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < weight.Length; i++)
{
    var dict = new Dictionary<string, int>();

    dict["weight"] = weight[i];

    if (weight[i] > 23)
    {
        dict["price"] = (weight[i] - 23) * 15;
    } else
    {
        dict["price"] = 0;
    }
    list.Add(dict);
}

int n = 1;
foreach (var item in list)
{
    Console.WriteLine($"{n}. Weight is: {item["weight"]}kg    |   Additional price is: {item["price"]}$\r\n");
    n++;
}

