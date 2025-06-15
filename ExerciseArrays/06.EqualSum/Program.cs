namespace _06.EqualSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                .ToArray();
            bool found = false;
            for (int i = 0; i < arr1.Length; i++)
            {
                int sumLeft = 0;
                int sumRight = 0;
                
                for (int left = 0; left < i; left++)
                {
                  sumLeft += arr1[left];
                  
                }
                for (int right = i + 1; right < arr1.Length; right++)
                {
                    sumRight += arr1[right];
                }

                if (sumLeft == sumRight)
                {
                    Console.WriteLine(i);
                    found = true;
                    break;

                }
                        


            }
            if (!found)
            {
                Console.WriteLine("no");
            }

        }
    }
}
