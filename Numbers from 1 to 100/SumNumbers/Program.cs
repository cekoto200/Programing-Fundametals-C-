﻿int numberCount = int.Parse(Console.ReadLine());
int sum = 0;

for (int i = 1; i <= numberCount; i++)
{
    int num = int.Parse(Console.ReadLine());
    sum += num;
}
Console.WriteLine(sum);