int AgeOfLilly = int.Parse(Console.ReadLine());
double WashingMachinePrice = double.Parse(Console.ReadLine());
int ToyPrice = int.Parse(Console.ReadLine());
int toysCount = 0;
double moneySaved = 0;
double intakeMoney = 0;
for (int i = 1; i <= AgeOfLilly; i++)
{
    if (i % 2 == 0)
    {
        intakeMoney += 10;
        moneySaved += intakeMoney;
        moneySaved--;
    }
    else
    {
        toysCount++;
    }
}
double toysSum = toysCount * ToyPrice;
moneySaved += toysSum;

if (moneySaved >= WashingMachinePrice)
{
    double leftMoney = moneySaved - WashingMachinePrice;
    Console.WriteLine($"Yes! {leftMoney:f2}");
}
else
{
    double moneyNeded = WashingMachinePrice - moneySaved;
    Console.WriteLine($"No! {moneyNeded:f2}");
}
   
  