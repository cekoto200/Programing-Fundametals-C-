﻿namespace _09._Sum_of_Odd_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= count; i++)
            {
                Console.WriteLine("{0}", 2 * i - 1);
                sum += 2 * i - 1;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
