using System.Diagnostics.Tracing;

double inputChange = double.Parse(Console.ReadLine());
int change = (int)Math.Round(inputChange * 100);
int changeCounter = 0;

while (change > 0)
{
    if (change - 200 >= 0)
    {
        change -= 200;
        changeCounter++;
    }
    else if (change - 100 >= 0)
    {
        change -= 100; changeCounter++;
    }
    else if (change - 50 >= 0)
    {
        change -= 50; changeCounter++;
    }
    else if (change - 20 >= 0)
    {
        change -= 20; changeCounter++;
    }
    else if (change - 10 >= 0)
    {
        change -= 10; changeCounter++;
    }
    else if (change - 5 >= 0)
    {
        change -= 5; changeCounter++;
    }
    else if (change - 2 >= 0)
    {
        change -= 2; changeCounter++;
    }
    else if (change - 1 >= 0)
    {
        change -= 1; changeCounter++;
    }
}
Console.WriteLine(changeCounter);