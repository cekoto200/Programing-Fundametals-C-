int start = int.Parse(Console.ReadLine());
int end = int.Parse(Console.ReadLine());
int magicNumber = int.Parse(Console.ReadLine());
int combinationCounter = 0;
bool isFound = false;
for (int x = start; x <= end; x++)
{
    for (int y = start; y <= end; y++)
    {
        int result = x + y;
        combinationCounter++;
        if (result == magicNumber)
        {
            isFound = true;
            Console.WriteLine($"Combination N:{combinationCounter} ({x} + {y} = {magicNumber})");
            break;
        }
    }
    if (isFound)
    {
        break;
    }
}
if (!isFound)
{
    Console.WriteLine($"{combinationCounter} combinations - neither equals {magicNumber}");
}
