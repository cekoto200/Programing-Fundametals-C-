namespace _05.TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte[] arr1 = Console.ReadLine()
                .Split()
                .Select(byte.Parse)
                .ToArray();
            
            for (int i = 0; i < arr1.Length; i++)
            {
                bool isTop = true;
                for (int j = i + 1; j < arr1.Length; j++)
                {
                    if (arr1[i] <= arr1[j])
                    {
                        isTop = false;
                        break;
                    }
                    
                }
                if (isTop)
                {
                    Console.Write(arr1[i] + " ");
                }
            }
            //int[] array = Console.ReadLine()
            //.Split()
            //.Select(int.Parse)
            //.ToArray();
            //
            //// Loop through each element
            //for (int i = 0; i < array.Length; i++)
            //{
            //    bool isTop = true;
            //
            //    for (int j = i + 1; j < array.Length; j++)
            //    {
            //        if (array[i] <= array[j])
            //        {
            //            isTop = false;
            //            break;
            //        }
            //    }
            //
            //    if (isTop)
            //    {
            //        Console.Write(array[i] + " ");
            //    }
            //}
        }
    }
}
