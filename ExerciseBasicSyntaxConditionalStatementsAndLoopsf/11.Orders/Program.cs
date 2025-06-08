using System.Diagnostics;

namespace _11.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            decimal totalSum = 0;
            for (int i = 1; i <= count; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());

                decimal coffePrice = (days * capsulesCount) * pricePerCapsule;
                totalSum += coffePrice;
                Console.WriteLine($"The price for the coffee is: ${coffePrice:f2}");
            }

            Console.WriteLine($"Total: ${totalSum:f2}");
        }
    }
}
