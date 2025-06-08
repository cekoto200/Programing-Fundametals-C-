namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfPeople = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double price = 0;
            if (dayOfWeek == "Friday")
            {
                switch (type)
                {
                    case "Students":
                        price = 8.45;
                        break;
                    case "Business":
                        price = 10.90;
                        break;
                    case "Regular":
                        price = 15;
                        break;
                    
                }
            }
            else if (dayOfWeek == "Saturday")
            {
                switch (type)
                {
                    case "Students":
                        price = 9.8;
                        break;
                    case "Business":
                        price = 15.6;
                        break;
                    case "Regular":
                        price = 20;
                        break;

                }
            }
            else if (dayOfWeek == "Sunday")
            {
                switch (type)
                {
                    case "Students":
                        price = 10.46;
                        break;
                    case "Business":
                        price = 16;
                        break;
                    case "Regular":
                        price = 22.5;
                        break;

                }
            }

            double totalSum = numOfPeople * price;
            
            if (type == "Students" && numOfPeople >= 30)
            {
                totalSum *= 0.85;
            }
            else if (type == "Business" && numOfPeople >= 100)
            {
                numOfPeople -= 10;
            }
            else if (type == "Regular" && 10 <= numOfPeople && numOfPeople <= 20)
            {
                totalSum *= 0.95;
            }

            Console.WriteLine($"Total price: {totalSum:f2}");
        }
    }
}
