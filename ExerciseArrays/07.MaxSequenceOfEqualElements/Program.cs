namespace _07.MaxSequenceOfEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
           byte[] array = Console.ReadLine()
                .Split()
                .Select(byte.Parse)
                .ToArray();
            int maxLenght = 1;
            int currentLenght = 1;
            int bestElement = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == array[i - 1])
                {
                    currentLenght++;
                }
                else
                    currentLenght = 1;

                if (currentLenght > maxLenght)
                {
                    maxLenght = currentLenght;
                    bestElement = array[i];
                }
                

            }
            
               for (int i = 0; i < maxLenght; i++)
            {
                Console.Write(bestElement + " ");
            }
        }
    }
}
