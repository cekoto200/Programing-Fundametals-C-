//Нощувка - 20 лв.
//Карта за транспорт - 1.60 лв.
//Билет за музей - 6 лв

int night = 20;
double transportCard = 1.60;
int museum = 6;

int people = int.Parse(Console.ReadLine());
int nightStay = int.Parse(Console.ReadLine());
int transport = int.Parse(Console.ReadLine());
int museumCard = int.Parse(Console.ReadLine());

int nightStayMoney = nightStay * night;
double transportCardMoney = transportCard * transport;
int museumMoney = museum * museumCard;

double peopleMoney = museumMoney + transportCardMoney + nightStayMoney;
double totalMoney = (people * peopleMoney) * .25;
Console.WriteLine($"{totalMoney:f2}");