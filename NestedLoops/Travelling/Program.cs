string destination = Console.ReadLine();

while (destination != "End")
{
    int budget = int.Parse(Console.ReadLine());
    int inputSum = 0;
    while (inputSum < budget)
    {
        inputSum += int.Parse(Console.ReadLine());
    }
   
    Console.WriteLine($"Going to {destination}!");
    
    destination = Console.ReadLine();
}



