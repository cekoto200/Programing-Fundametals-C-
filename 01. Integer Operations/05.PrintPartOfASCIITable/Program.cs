namespace _05.PrintPartOfASCIITable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int input1 = int.Parse(Console.ReadLine());
            int input2 = int.Parse(Console.ReadLine());
            string displayChar;
            for (int i = input1; i <= input2; i++)
            {
                char ch = (char)i;
                
                displayChar = ch.ToString();
                
                Console.Write($"{displayChar} ");
                
            }

        }
    }
}
