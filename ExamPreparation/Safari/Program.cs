double budget = double.Parse(Console.ReadLine());
int nights = int.Parse(Console.ReadLine());
double nightPrice  = double.Parse(Console.ReadLine());
int percent = int.Parse(Console.ReadLine());

if  (nights > 7)
{
    nightPrice -= nightPrice * 0.05;
}

double money = nightPrice * nights;
budget = budget * ((double)percent / 100);

if (budget >= money)
{
    Console.WriteLine($"Ivanovi will be left with {budget - money:f2} leva after vacation.");

}
else
    Console.WriteLine($"{money - budget:f2} leva needed.");