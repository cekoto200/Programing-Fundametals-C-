namespace _11._Multiplication_Table_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());
            int sum = 0;
            do
            {
                sum = num * multiplier;
                Console.WriteLine($"{num} X {multiplier} = {sum}");
                multiplier++;
            }
            while (multiplier <= 10);
        }
    }
}
