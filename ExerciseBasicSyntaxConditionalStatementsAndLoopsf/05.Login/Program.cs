using System.Runtime.InteropServices;

namespace _05.Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = string.Empty;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                char currentChar = username[i];

                password += currentChar;
            }
            int attempts = 1;
            while (true)
            {
                
                string inputpassword = Console.ReadLine();
                if (inputpassword == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                
                else if (attempts >= 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                else if (inputpassword != password)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
                attempts++;
            }
           
        }
    }
}
