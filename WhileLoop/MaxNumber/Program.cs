string input = Console.ReadLine();
int maxnum = int.MinValue;

while (input != "Stop")
{
    if (int.Parse(input) > maxnum)
    {
        maxnum = int.Parse(input);
    }
    input = Console.ReadLine();
}
Console.WriteLine(maxnum);