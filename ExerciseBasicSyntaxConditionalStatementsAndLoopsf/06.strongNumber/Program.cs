namespace _06.strongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int initialNumber = number;
            int sum = 0;

            while (number > 0)
            {
                int factorial = 1;
                int lastDigit = number % 10;
                number /= 10;

                for (int i = 1; i <= lastDigit; i++)
                {
                    factorial *= i;
                }
                sum += factorial;

            }
            if (initialNumber == sum)
            {
                Console.WriteLine("yes");
            }
            else
                Console.WriteLine("no");
        }
    }
}
