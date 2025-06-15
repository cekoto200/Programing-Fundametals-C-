namespace _04.ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine()
                .Split()
                .ToArray();
            byte rotations = byte.Parse(Console.ReadLine());

            
            for (int i = 0; i < rotations; i++)
            {
                string firstElemnt = arr1[0];

                for (int j = 0; j < arr1.Length - 1; j++)
                {
                    arr1[j] = arr1[j + 1];
                }

                arr1[arr1.Length - 1] = firstElemnt;
            }
            Console.WriteLine(string.Join(" ", arr1));
        }
    }
}
