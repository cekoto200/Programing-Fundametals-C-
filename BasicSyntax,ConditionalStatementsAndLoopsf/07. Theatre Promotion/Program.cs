namespace _07._Theatre_Promotion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string price = string.Empty;
            if (0 <= age && age <= 18)
            {
                switch (day)
                {
                    case "Weekday":
                        price = "12$";
                        break;
                    case "Weekend":
                        price = "15$";
                        break;
                    case "Holiday":
                        price = "5$";
                        break;
                    default:
                        price = "Error!";
                        break;
                }
            }
            else if (18 < age && age <= 64)
            {
                switch (day)
                {
                    case "Weekday":
                        price = "18$";
                        break;
                    case "Weekend":
                        price = "20$";
                        break;
                    case "Holiday":
                        price = "12$";
                        break;
                    default:
                        price = "Error!";
                        break;
                }
            }
            else if (64 < age && age <= 122)
            {
                switch (day)
                {
                    case "Weekday":
                        price = "12$";
                        break;
                    case "Weekend":
                        price = "15$";
                        break;
                    case "Holiday":
                        price = "10$";
                        break;
                    default:
                        price = "Error!";
                        break;
                }
            }
            else
            {
                price = "Error!";
            }
            Console.WriteLine(price);
        }
    }
}
