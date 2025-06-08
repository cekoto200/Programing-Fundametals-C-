//Дестинация
//         Dubai     Sofia      London
//Winter 45 000 lv. 17 000 lv. 24 000 lv.
//Summer 40 000 lv. 12 500 lv. 20 250 lv.
//Съществуват следните данъчни облекчения/облагания:
//• Ако дестинацията е Дубай – 30% отстъпка от крайната цена
//• Ако дестинацията е София – цената се оскъпява с 25%
//Вход
//От конзолата се четат 4 реда:
//1. Бюджет на филма – реално число в диапазона [100 000.0… 2 000 000.0]
//2. Дестинация – текст, с възможности "Dubai", "Sofia" и "London"
//3. Сезон – текст, с възможности "Summer" и "Winter"
//4. Брой дни – цяло число в диапазона [1… 40]Съществуват следните данъчни облекчения/облагания:

double budget = double.Parse(Console.ReadLine());
string destination = Console.ReadLine();
string season = Console.ReadLine();
int days = int.Parse(Console.ReadLine());
int winterPrice = 0;
int summerPrice = 0;
double money = 0;

switch (destination)
{
    case "Dubai":
        if (season == "Winter")
        {
            winterPrice = 45000;
            money = winterPrice * days;
        }
        else
        {
            summerPrice = 40000;
            money = summerPrice * days;
        }
        money -= money * 0.3;
            break;

    case "Sofia":
        if (season == "Winter")
        {
            winterPrice = 17000;
            money = winterPrice * days;
        }
        else
        {
            summerPrice = 12500;
            money = summerPrice * days;
        }
        money += money * 0.25;
            break;
    case "London":
        if (season == "Winter")
        {
            winterPrice = 24000;
            money = winterPrice * days;
        }
        else
        {
            summerPrice = 20250;
            money = summerPrice * days;
        }
        break;
}

if (budget >= money)
{
    Console.WriteLine($"The budget for the movie is enough! We have {budget - money:f2} leva left!");
}
else
{
    Console.WriteLine($"The director needs {money - budget:f2} leva more!");
}