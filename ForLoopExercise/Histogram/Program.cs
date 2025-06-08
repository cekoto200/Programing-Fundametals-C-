//. От тях някакъв процент p1 са под 200,
//друг процент p2 са от 200 до 399,
//друг процент p3 са от 400 до 599,
//друг процент p4 са от 600 до 799 и
//останалите p5 процента са от 800 нагоре.
//Да се напише програма, която изчислява и
//отпечатва процентите p1, p2, p3, p4 и p5.
int n = int.Parse(Console.ReadLine());
double p1 = 0;
double p2 = 0;
double p3 = 0;
double p4 = 0;
double p5 = 0;
for (int i = 1; i <= n; i++)
{
    int num = int.Parse(Console.ReadLine());
    if (num < 200)
    {
        p1++;
    }
    else if (num >= 200 && num <= 399)
    {
        p2++;
    }
    else if (num >= 400 && num <= 599)
    {
        p3++;
    }
    else if (num >= 600 && num <= 799)
    {
        p4++;
    }
    else if (num >= 800)
    {
        p5++;
    }
}
double p1Percentege = p1 / n * 100;
double p2Percentege = p2 / n * 100;
double p3Percentege = p3 / n * 100;
double p4Percentege = p4 / n * 100;
double p5Percentege = p5 / n * 100;

Console.WriteLine($"{p1Percentege:f2}%");
Console.WriteLine($"{p2Percentege:f2}%");
Console.WriteLine($"{p3Percentege:f2}%");
Console.WriteLine($"{p4Percentege:f2}%");
Console.WriteLine($"{p5Percentege:f2}%");