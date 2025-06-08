//Мария решава да мине на диета и отива до близкия пазар, за да купи ягоди, банани, портокали и
//малини. На конзолата се въвежда цената на ягодите в лв./кг. и количеството на бананите,
//портокалите, малините и ягодите, които трябва да закупи. Да се напише програма, която
//пресмята колко пари са ѝ необходими за да плати сметката, като знаете, че:
//• цената на малините е на половина по-ниска от тази на ягодите;
//• цената на портокалите е с 40% по-ниска от цената на малините;
//• цената на бананите е с 80% по-ниска от цената на малините.
//Вход
//От конзолата се четат 5 реда:
//1. Цена на ягодите в лева – реално число в интервала [0.00 … 10000.00]
//2. Количество на бананите в килограми – реално число в интервала [0.00 … 1 0000.00]
//3. Количество на портокалите в килограми – реално число в интервала [0.00 … 10000.00]
//4. Количество на малините в килограми – реално число в интервала [0.00 … 10000.00]
//5. Количество на ягодите в килограми – реално число в интервала [0.00 … 10000.00]

double strawberiesPrice = double.Parse(Console.ReadLine());
double raspberiesPrice = strawberiesPrice / 2;
double bananasPrice = raspberiesPrice * 0.2;
double orangesPrice = raspberiesPrice * 0.6;

double bananas = double.Parse(Console.ReadLine()) * bananasPrice;
double oranges  = double.Parse(Console.ReadLine()) * orangesPrice;
double raspberies = double.Parse(Console.ReadLine()) * raspberiesPrice;
double strawberies = double.Parse(Console.ReadLine()) * strawberiesPrice;

double money = bananas + oranges + strawberies + raspberies;
Console.WriteLine($"{money:f2}");