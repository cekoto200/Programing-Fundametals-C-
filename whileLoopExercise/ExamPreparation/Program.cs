int failedTimes = int.Parse(Console.ReadLine());
string problem = "";
double grade = 0;
double gradesum = 0;
int failedTimesCounter = 0;
int problemsCounter = 0;
string lastProblem = "";
while ((problem = Console.ReadLine()) != "Enough")
{
    problemsCounter++;
    grade = double.Parse(Console.ReadLine());
    if (grade <= 4)
    {
      failedTimesCounter++;
        if (failedTimesCounter == failedTimes)
        {
            Console.WriteLine($"You need a break, {failedTimesCounter} poor grades.");
            break;
        }
        
    }
    gradesum += grade;
    lastProblem = problem;
}
double averageGrade = gradesum / problemsCounter;
if (problem == "Enough")
{
    Console.WriteLine($"Average score: {averageGrade:f2}");
    Console.WriteLine($"Number of problems: {problemsCounter}");
    Console.WriteLine($"Last problem: {lastProblem}");
}