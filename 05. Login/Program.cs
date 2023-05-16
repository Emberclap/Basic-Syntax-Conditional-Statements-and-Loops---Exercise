using System;
using System.Diagnostics.Metrics;

namespace _05._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            char[] pass = username.ToCharArray();
            Array.Reverse(pass);
            string passwordRequired = new string(pass);
            string password = Console.ReadLine();
            int counter = 1;
            while (password != passwordRequired)
            {
                Console.WriteLine($"Incorrect password. Try again.");

                password = Console.ReadLine();
                counter++;
                if (counter == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }
            }
            Console.WriteLine($"User {username} logged in.");
        }
    }
}