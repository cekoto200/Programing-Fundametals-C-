//"Facebook" -> 150 лв.
//· "Instagram"-> 100 лв.
//· "Reddit"-> 50 лв.

using System.ComponentModel.DataAnnotations;

int facebookFine = 150;
int instagramFine = 100;
int redditFine = 50;

int openTabs = int.Parse(Console.ReadLine());
int salary = int.Parse(Console.ReadLine());

for (int i = 1; i <= openTabs; i++)
{
    string nameOfTab = Console.ReadLine();
	switch (nameOfTab)
	{
		case "Facebook":
			salary -= facebookFine;
            break;
		case "Instagram":
			salary -= instagramFine;
			break;
		case "Reddit":
			salary -= redditFine;
			break;


    }
}
if (salary <= 0)
{
    Console.WriteLine( "You have lost your salary.");
}
else
{
    Console.WriteLine(salary);
}