using System.Collections;

Queue BordingPass = new Queue(3);
Queue BordingPass1 = new Queue(3);
Queue BordingPass2 = new Queue(3);
int BordingPass3;

Console.WriteLine("Enter 10 bording pass numbers");
for (int i = 0;i <= 2; i++)
{
    BordingPass.Enqueue(int.Parse(Console.ReadLine()));
}

for (int j = 0; j <= 2; j++)
{
    BordingPass1.Enqueue(int.Parse(Console.ReadLine()));
}

for (int k = 0; k <= 2; k++)
{
    BordingPass2.Enqueue(int.Parse(Console.ReadLine()));
}


BordingPass3 = int.Parse(Console.ReadLine());


var RandomNumber = new Random().Next(1, 4);
Console.WriteLine(RandomNumber);

if (RandomNumber.Equals(1))
{
    BordingPass.Dequeue();
    BordingPass.Enqueue(BordingPass3);
    Console.WriteLine($"Removed queue {RandomNumber}");

    foreach (var item in BordingPass)
    {
        Console.WriteLine($"items {item}");
    }
}
else if (RandomNumber.Equals(2))
{
    BordingPass1.Dequeue();
    BordingPass1.Enqueue(BordingPass3);
    Console.WriteLine($"Removed queue {RandomNumber}");

    foreach (var item in BordingPass1)
    {
        Console.WriteLine($"items {item}");
    }
}
else if (RandomNumber.Equals(3))
{
    BordingPass2.Dequeue();
    BordingPass2.Enqueue(BordingPass3);
    Console.WriteLine($"Removed queue {RandomNumber}");
    foreach (var item in BordingPass2)
    {
        Console.WriteLine($"items {item}");
    }
}




