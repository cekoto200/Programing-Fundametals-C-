﻿int n = int.Parse(Console.ReadLine());
int leftSum = 0;

for (int i = 1; i <= n; i++)
{
    leftSum = leftSum + int.Parse(Console.ReadLine());
}
int  rightSum = 0;
for (int i = 1; i <= n; i++)
{
    rightSum = rightSum + int.Parse(Console.ReadLine());
}

if (leftSum == rightSum)
{
    Console.WriteLine(" Yes, sum = " + rightSum);
}
else
{
    int diif = Math.Abs(leftSum - rightSum);
    Console.WriteLine("No, diff = " + diif);
}