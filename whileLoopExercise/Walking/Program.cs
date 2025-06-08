int stepsGoal = 10000;
string stepsTaken = "";
int totalSteps = 0;

while (totalSteps < stepsGoal)
{
    stepsTaken = (Console.ReadLine());
    if (stepsTaken == "Going home")
    {
        stepsTaken = Console.ReadLine();
        totalSteps += int.Parse(stepsTaken);
        break;
    } 
   
    
    totalSteps += int.Parse(stepsTaken);
        
}
if (totalSteps < stepsGoal)
{
    Console.WriteLine($"{stepsGoal - totalSteps} more steps to reach goal.");

}
else
{
    Console.WriteLine("Goal reached! Good job!");
    Console.WriteLine($"{totalSteps - stepsGoal} steps over the goal!");
}