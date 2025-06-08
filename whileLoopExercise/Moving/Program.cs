int leght = int.Parse(Console.ReadLine());
int widht = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());

int numberOfBoxes = widht * height * leght;
string boxes = "";

while ((boxes = Console.ReadLine()) != "Done")
{
    int currentBoxes = int.Parse(boxes);
    numberOfBoxes -= currentBoxes;
    if (numberOfBoxes < 0)
    {
        Console.WriteLine($"No more free space! You need {Math.Abs(numberOfBoxes)} Cubic meters more.");
        break;
    }
}
if  (numberOfBoxes >= 0)
{
    Console.WriteLine($"{numberOfBoxes} Cubic meters left.");
}