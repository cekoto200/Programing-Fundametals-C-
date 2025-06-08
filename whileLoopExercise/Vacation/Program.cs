double neededMoney = double.Parse(Console.ReadLine());
double balance = double.Parse(Console.ReadLine());
int spendDaysCounter = 0;
string actionType = "";
double investedAmount = 0.0;
int daysCounter = 0;
while (balance < neededMoney)
{
    actionType = Console.ReadLine();
    investedAmount = double.Parse(Console.ReadLine());
    daysCounter++;
    if (actionType == "spend")
    {
        spendDaysCounter++;
        balance -= investedAmount;
        if (balance < 0)
        {
            balance = 0;
        }
        
        if (spendDaysCounter >= 5)
        {
            Console.WriteLine("You can't save the money.");
            Console.WriteLine(daysCounter);
            break;
        }
    }
    else if (actionType == "save")
    {
        spendDaysCounter = 0;
        balance += investedAmount;
    }

            
}
if (balance >= neededMoney)
{
    Console.WriteLine($"You saved the money for {daysCounter} days.");
}