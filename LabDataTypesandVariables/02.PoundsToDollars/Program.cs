namespace _02.PoundsToDollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pounds = double.Parse(Console.ReadLine());
            double poundsToDollars = pounds * 1.31;
            Console.WriteLine($"{poundsToDollars:f3}");
        }
    }
}
