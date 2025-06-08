namespace _06.TriplesOfLatinLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (char i = 'a'; i < 'a' + number; i++)
            {
                for (char j = 'a'; j < 'a' + number; j++)
                {
                    for (char k = 'a'; k < 'a' + number; k++)
                    {
                        Console.WriteLine($"{i}{j}{k}");
                    }
                }
            }
            //for (int i = 0; i < number - 1; i++)
            //{
            //    char firstChar = (char)('a' + i);
            //    Console.Write(firstChar);
            //    for (int j = 0; j < number - 1; j++)
            //    {
            //        char secondChar = (char)('b' + i);
            //        Console.Write($"{secondChar}");
            //        for (int k = 0; k < number - 1; k++)
            //        {
            //            char thirdChar = (char)('c' + i);
            //            Console.Write($"{thirdChar}");
            //            
            //        }
            //
            //    }
            //    
            //}

        }
    }
}
