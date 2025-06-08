namespace Convert_Meters_to_Kilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double metersToKilometers = num / 1000;
            Console.WriteLine($"{metersToKilometers:f2}");
        }
    }
}
