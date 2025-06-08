namespace _04.SumOfChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
             int numberOfLines = int.Parse(Console.ReadLine());
            int sym = 0;
            for (int i = 1; i <= numberOfLines; i++)
            {
                string ascii = Console.ReadLine();
                char symbol = ascii[0];
                int asciiValue = (int)symbol;
                sym += asciiValue;
            }
            Console.WriteLine($"The sum equals: {sym}");
        }
    }
}
