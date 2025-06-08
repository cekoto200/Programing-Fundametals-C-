namespace _08.BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte numberOfKegs = byte.Parse(Console.ReadLine());
            double actualVolume = 0;
            double volume = 0;
            string biggestKegName = null;
            for (int i = 0; i < numberOfKegs; i++)
            {
                string typeOfKeg = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                uint height = uint.Parse(Console.ReadLine());

                volume = Math.PI * Math.Pow(radius, 2) * height; 
                if (volume > actualVolume)
                {
                    actualVolume = volume;
                    biggestKegName = typeOfKeg;
                }
            }
            Console.WriteLine(biggestKegName);
        }
    }
}
