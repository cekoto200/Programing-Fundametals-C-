int daysCounter = 1;
int everest = 8848;

int meters = 5364; 
string comand = Console.ReadLine();
while (comand != "END")
{
    if (comand == "Yes")
    {
        daysCounter++;
    }

    meters += int.Parse(Console.ReadLine());
   
    if (meters >= everest)
    {
        break;
    }

    if (daysCounter >= 5)
    {
        break;
    }

     comand = Console.ReadLine();
}
if (meters >= everest)
{
    Console.WriteLine($"Goal reached for {daysCounter} days!");
}
else
{
    Console.WriteLine("Failed!");
    Console.WriteLine(meters);
}