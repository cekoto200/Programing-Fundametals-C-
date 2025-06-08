using System.Diagnostics;

namespace _07.VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nuts = 2.0;
            double water = 0.7;
            double crisps = 1.5;
            double soda = 0.8;
            double coke = 1.0;
            string coin;
            string item;
            double sum = 0;
            while ((coin = Console.ReadLine()) != "Start")
            {
                
                 if (double.Parse(coin) == 0.1 || double.Parse(coin) == 0.2 || double.Parse(coin) == 0.5 || double.Parse(coin) == 1 || double.Parse(coin) == 2)
                {
                    
                    sum += double.Parse(coin);
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coin}");
                    continue;
                }
                
            }
            
            while ((item = Console.ReadLine()) != "End")
            {
                if (item == "Nuts" || item == "Water" || item == "Crisps" || item == "Soda" || item == "Coke")
                {
                   if (item == "Nuts" && sum >= nuts)
                    {
                        Console.WriteLine("Purchased nuts");
                        sum -= nuts;
                        continue;
                    }
                   else if (item == "Water" && sum >= water)
                    {
                        Console.WriteLine("Purchased water");
                        sum -= water;
                        continue;
                    }
                   else if (item == "Crisps" && sum >= crisps)
                    {
                        Console.WriteLine("Purchased crisps");
                        sum -= crisps;
                        continue;
                    }
                   else if (item == "Soda" && sum >= soda)
                    {
                        Console.WriteLine("Purchased soda");
                        sum -= soda;
                        continue;
                    }
                   else if (item == "Coke" && sum >= coke)
                    {
                        Console.WriteLine("Purchased coke");
                        sum -= coke;
                        continue;
                    }
                   else
                        Console.WriteLine("Sorry, not enough money");
                    continue;
                }
                else
                {
                    Console.WriteLine("Invalid product");
                    continue;
                        
                }
            }

            Console.WriteLine($"Change: {sum:f2}");
        }
    }
}
