//Любовно послание - 0.60 лв.
//Восъчна роза - 7.20 лв.
//Ключодържател - 3.60 лв.
//Карикатура - 18.20 лв.
//Късмет изненада - 22 лв.


double neededMoney = double.Parse(Console.ReadLine());
double loveLetternum = double.Parse(Console.ReadLine()) ;
double roseNum = double.Parse(Console.ReadLine());
double keychainNum = double.Parse(Console.ReadLine());
double karikaturiNum = double.Parse(Console.ReadLine());
double supriseNum = double.Parse(Console.ReadLine());
double numberOfArticle = neededMoney + loveLetternum + roseNum + keychainNum + supriseNum ;

double loveLetter = 0.6 * loveLetternum;
double rose = 7.20 * roseNum;
double keyChain = 3.60 * keychainNum;
double karikatura = 18.20 * karikaturiNum;
double suprise = 22 * supriseNum;
double totalPrice = loveLetter + rose + keyChain + karikatura + suprise;

if (numberOfArticle >= 25)
{
    totalPrice -= totalPrice * 0.35;
}

totalPrice -= totalPrice * 0.1;

if ( totalPrice > neededMoney)
{
    Console.WriteLine($"Yes! {totalPrice - neededMoney:f2} lv left.");
}
else
{
    Console.WriteLine($"Not enough money! {neededMoney - totalPrice:f2} lv needed.");
}

    
