string student = Console.ReadLine();
double sumOcenki = 0.0;
int grade = 1;
int timesFailed = 0;

while (grade <= 12)
{
    double ocenka = double.Parse(Console.ReadLine());
    if (ocenka < 4)
    {
        timesFailed++;
        if (timesFailed >= 2)
        {
            Console.WriteLine($"{student} has been excluded at {grade} grade");
                break;
        }
        continue;
    }
    sumOcenki += ocenka;
    grade++;
}
if (grade >= 12)
{
    double averageOcenka = sumOcenki / 12;
    Console.WriteLine($"{student} graduated. Average grade: {averageOcenka:f2}");
}
   