namespace _12.RefactorSpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int kolkko = int.Parse(Console.ReadLine());
            int count = int.Parse(Console.ReadLine());
            //int obshto = 0;
            
            //int takova = 0;
            
            

            for (int i = 1; i <= count; i++)

            {
                int sum = 0;

                int number = i;
                //takova = ch;

                while (number > 0)

                {
                    
                    sum += number % 10;

                    number /= 10;

                }

                bool isSpecialNumber = (sum == 5) || (sum == 7) || (sum == 11);

                
                Console.WriteLine("{0} -> {1}", i, isSpecialNumber);


            }
        }
    }
}
