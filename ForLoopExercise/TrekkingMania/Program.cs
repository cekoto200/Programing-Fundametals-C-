//⦁	Група до 5 човека – изкачват Мусала
//⦁	Група от 6 до 12 човека – изкачват Монблан
//⦁	Група от 13 до 25 човека – изкачват Килиманджаро
//⦁	Група от 26 до 40 човека –  изкачват К2
//⦁	Група от 41 или повече човека – изкачват Еверест
int Musala = 0;
int Monblan = 0;
int Kilimadjaro = 0;
int K2 = 0;
int everest = 0;
int totalNumberOfPeople = 0;

int numOfGroups = int.Parse(Console.ReadLine());

for (int i = 1; i <= numOfGroups; i++)
{
     int numOfPeople = int.Parse(Console.ReadLine());
    totalNumberOfPeople += numOfPeople;
    if (numOfPeople <= 5)
    {
        Musala += numOfPeople;
    }
    else if (numOfPeople >= 6 && numOfPeople <= 12)
    {
        Monblan += numOfPeople;
    }
    else if (numOfPeople >= 13 && numOfPeople <= 25)
    {
        Kilimadjaro += numOfPeople;
    }
    else if (numOfPeople >= 26 && numOfPeople <= 40)
    {
        K2 += numOfPeople;
    }
    else if (numOfPeople >= 41)
    {
        everest += numOfPeople;
    }
}
double percentegeMusala = (double)Musala / totalNumberOfPeople * 100;
double percentegeMonblan =  (double)Monblan / totalNumberOfPeople * 100;
double percentegeKilimanjaro = (double)Kilimadjaro / totalNumberOfPeople * 100;
double percenetegeK2 = (double)K2 / totalNumberOfPeople * 100;
double percentegeEverest = (double)everest / totalNumberOfPeople * 100;

Console.WriteLine($"{percentegeMusala:f2}%");
Console.WriteLine($"{percentegeMonblan:f2}%");
Console.WriteLine($"{percentegeKilimanjaro:f2}%");
Console.WriteLine($"{percenetegeK2:f2}%");
Console.WriteLine($"{percentegeEverest:f2}%");