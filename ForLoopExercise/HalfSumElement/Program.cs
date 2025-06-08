int n = int.Parse(Console.ReadLine());
int numSum = 0;
int max = int.MinValue;
for (int i = 1; i <= n; i++)
{
    int num = int.Parse(Console.ReadLine());
    numSum += num;
    if (num > max)
    {
        max = num;
    }
   
}

int sumWithoutMaxNumber = numSum - max;
if (max == sumWithoutMaxNumber)
{
    Console.WriteLine("Yes");
    Console.WriteLine("Sum = " + max);
}
else
{
    int diff = Math.Abs(sumWithoutMaxNumber - max);
    Console.WriteLine("No");
    Console.WriteLine("Diff = " + diff);
}