namespace _10.RageExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int brokenHeadset = (lostGames / 2);
            int brokenMouse = (lostGames / 3);
            int brokenKeyboard = (lostGames / 6);
            int brokenDisplay = (brokenKeyboard / 2);

            double rageExpenses = brokenKeyboard * keyboardPrice + brokenDisplay * displayPrice + brokenHeadset * headsetPrice + brokenMouse * mousePrice;
            Console.WriteLine($"Rage expenses: {rageExpenses:f2} lv.");
        }
    }
}
