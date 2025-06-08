string actor = Console.ReadLine();
double points = double.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    string nameOfjudge = Console.ReadLine();
    double givenPoints = double.Parse(Console.ReadLine());
    
   points += nameOfjudge.Length * givenPoints / 2;
    if (points > 1250.5)
    {
        Console.WriteLine($"Congratulations, {actor} got a nominee for leading role with {points:f1}!");
        break;
    }
}



if (points <= 1250.5)
{
    double pointsNeded = 1250.5 - points;
    Console.WriteLine($"Sorry, {actor} you need {pointsNeded:f1} more!");
}