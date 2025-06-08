namespace _04.CenturiesToMinutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte centuries = byte.Parse(Console.ReadLine());
            ushort years = (ushort)(centuries * 100);
            uint days = (uint)(years * 365.242);
            ulong hours = days * 24u;
            ulong minutes = hours * 60u;
            Console.WriteLine($"{centuries} centuries = {years} years = {(days)} days = {(hours)} hours = {(minutes)} minutes");
        }
    }
}
