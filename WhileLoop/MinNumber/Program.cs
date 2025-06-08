string input = Console.ReadLine();
int mannum = int.MaxValue;

while (input != "Stop")
{
    if (int.Parse(input) < mannum)
    {
        mannum = int.Parse(input);
    }
    input = Console.ReadLine();
}
Console.WriteLine(mannum);