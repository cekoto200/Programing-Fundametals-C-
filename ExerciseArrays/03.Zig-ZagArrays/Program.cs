using System;

namespace _03.Zig_ZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfNumbers = int.Parse(Console.ReadLine());

            int[] arr1 = new int[countOfNumbers];
            int[] arr2 = new int[countOfNumbers];

            for (int i = 0; i < countOfNumbers; i++)
            {
                string[] input = Console.ReadLine().Split();
                int num1 = int.Parse(input[0]);
                int num2 = int.Parse(input[1]);

                if (i % 2 == 0)
                {
                    arr1[i] = num1;
                    arr2[i] = num2;
                }
                else
                {
                    arr1[i] = num2;
                    arr2[i] = num1;
                }
            }
            Console.WriteLine(string.Join(" ", arr1));
            Console.WriteLine(string.Join(" ", arr2));

        }
    }
}
