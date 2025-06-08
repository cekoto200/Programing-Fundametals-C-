namespace _09.PadawanEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int countOfStudents = int.Parse(Console.ReadLine());
            double lightsabersPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            int freeBlets = countOfStudents / 6;
            double brokeSaber = Math.Ceiling(countOfStudents * 1.1);

            double totalSaber = lightsabersPrice * brokeSaber;
            double totalRobes = robesPrice * countOfStudents;
            double totalBelts = beltPrice * (countOfStudents - freeBlets);
            double sum =  totalBelts + totalRobes + totalSaber;
           
            if (sum <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {sum:f2}lv.");
            }
            else
                Console.WriteLine($" John will need {sum - money:f2}lv more.");
        }
    }
}
