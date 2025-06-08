
//След завръщането си групата дарява 75% от сумата, след приспаднатите разходи, за благотворителност. Останалата сума се разпределя между членовете на групата.
//Да се  напише програма, която изчислява колко пари са дадени за благотворителност и колко е получил всеки един член на групата. 
//Вход:
//От конзолата се четат 4 реда:
//Брой танцьори – цяло число в интервала [1 … 10]
//Брой точки – реално число в интервала [1.00 … 10000.00]
//Сезон –  текст със следните възможности - "summer" или "winter"
//Място – текст със следните възможности - "Bulgaria" или "Abroad"
using System.Xml.Schema;

int dancers = int.Parse(Console.ReadLine());
double points = double.Parse(Console.ReadLine());
string season = Console.ReadLine();
string destination  = Console.ReadLine();
double totalPoints;
if (destination == "Bulgaria")
{
     totalPoints = dancers * points;
    if (season == "summer")
    {
        totalPoints -= totalPoints * 0.05;
    }
    else
    {
        totalPoints -= totalPoints * 0.08;
    }
}
else
{
     totalPoints = dancers * points;
    totalPoints += totalPoints / 2;
    if (season == "summer")
    {
        totalPoints -= totalPoints * 0.1;
    }
    else
    {
        totalPoints -= totalPoints * 0.15;
    }
}
double charitySum = totalPoints * 0.75;
totalPoints = totalPoints * 0.25;
double moneyPerDancer = totalPoints / dancers;
Console.WriteLine($"Charity - {charitySum:f2}");
Console.WriteLine($"Money per dancer - {moneyPerDancer:f2}");