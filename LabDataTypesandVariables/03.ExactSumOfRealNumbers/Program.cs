namespace _03.ExactSumOfRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            int numCount = int.Parse(Console.ReadLine());
            decimal numSum = default;
            for (int i = 1; i <= numCount; i++)
            {
                 decimal numbers = decimal.Parse(Console.ReadLine());
                numSum += numbers;
            }
            Console.WriteLine(numSum);
        }
    }
}
