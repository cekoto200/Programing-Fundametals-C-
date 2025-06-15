namespace _08.MagicSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine()
                        .Split()
                        .Select(int.Parse)
                        .ToArray();

            int sumOfNumbers = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = i + 1; j < arr1.Length; j++)
                {
                    if (arr1[i] + arr1[j] == sumOfNumbers)
                    {
                        Console.WriteLine($"{arr1[i]} {arr1[j]}");
                    }
                }
            }
        }
    }
}
