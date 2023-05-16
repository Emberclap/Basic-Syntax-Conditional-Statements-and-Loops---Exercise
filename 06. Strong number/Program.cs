using System.Diagnostics.Metrics;

namespace _06._Strong_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            int number = int.Parse(Console.ReadLine());
            int firstNumber = number;
            int factorial = 0;

            
            while (number > 0)
            {
                int n = number % 10;

                int counter = 1;
               
                for (int i = 1; i <= n; i++)
                {
                    counter *= i;
                }
                number /= 10;
                factorial += counter;

            }
            if (factorial == firstNumber)
            {
                Console.WriteLine($"yes");
            }
            else
            {
                Console.WriteLine($"no");
            }



        }
    }
}