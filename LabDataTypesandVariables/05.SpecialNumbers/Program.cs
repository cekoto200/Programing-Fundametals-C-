using System.Net.Http.Headers;

namespace _05.SpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
         

            for (int i = 1; i <= input; i++)
            {
                int sum = 0;
                int digits = i;
               while (digits > 0)
                {
                    sum += digits % 10;
                    digits /= 10;
                }
                  bool isSpecialNumber = sum % 5 == 0 || sum % 7 == 0 || sum % 11 == 0;
                if (isSpecialNumber) 
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                    Console.WriteLine($"{i} -> False");
            }
        }
    }
}
