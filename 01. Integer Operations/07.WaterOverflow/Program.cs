namespace _07.WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte entries = byte.Parse(Console.ReadLine());
            short tankVolume = 0;
            for (byte i = 0; i < entries; i++)
            {
                short liters = short.Parse(Console.ReadLine());
                
                if (tankVolume + liters > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;

                }
                
                tankVolume += liters;

               
                



            }
            Console.WriteLine(tankVolume);

        }
    }
}
