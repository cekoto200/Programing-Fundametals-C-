namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int[] numberOfWagons = Console.ReadLine()
            //     .Split()
            //     .Select(int.Parse)
            //     .ToArray();
            // int sum = 0;
            // 
            // for (int i = 0; i < numberOfWagons.Length; i++)
            // {
            //     numberOfWagons[i] = int.Parse(Console.ReadLine());
            //   
            //     sum += numberOfWagons[i];
            // }
            //
            // Console.WriteLine(string.Join(" ", numberOfWagons));
            // Console.WriteLine(sum);
            int n = int.Parse(Console.ReadLine());

            int[] wagons = new int[n];
            int totalPassengers = 0;

            // Read number of passengers for each wagon
            for (int i = 0; i < n; i++)
            {
                wagons[i] = int.Parse(Console.ReadLine());
                totalPassengers += wagons[i];
            }

            // Print passengers per wagon
            Console.WriteLine(string.Join(" ", wagons));

            // Print total passengers
            Console.WriteLine(totalPassengers);
        }
    }
}
