//⦁	W - ако е победител получава 2000 точки
//⦁	F - ако е финалист получава 1200 точки
//⦁	SF - ако е полуфиналист получава 720 точки
int winPoints = 2000;
int finalistPoints = 1200;
int semiFinalistPoints = 720;
int winScore = 0;
int finalistScore = 0;
int semiFinalistScore = 0;

int numberOfTournirs = int.Parse(Console.ReadLine());
int startPoints = int.Parse(Console.ReadLine());

for (int i = 1; i <= numberOfTournirs; i++)
{
    string reslut = Console.ReadLine();

	switch (reslut)
	{
		case "W":
			winScore++;
			break;
		case "F":
			finalistScore++; 
		    break;
		case "SF":
			semiFinalistScore++; 
			break;
	}
}
int totalPoints = winPoints * winScore
				 + finalistPoints * finalistScore
				 + semiFinalistPoints * semiFinalistScore;
				 
double averagePoints = totalPoints / numberOfTournirs;
double winPercentege = (double)winScore / (double)numberOfTournirs * 100;

Console.WriteLine($"Final points: {totalPoints + startPoints}");
Console.WriteLine($"Average points: {Math.Floor(averagePoints)}");
Console.WriteLine($"{winPercentege:f2}%");