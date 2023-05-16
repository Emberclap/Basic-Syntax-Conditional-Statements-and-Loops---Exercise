using System.ComponentModel.Design;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfPpl = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfTheWeek = Console.ReadLine();
            double price = 0;

            if (dayOfTheWeek == "Friday")
            {
                switch (typeOfGroup)
                {
                    case "Students": price = 8.45; break;
                    case "Business": price = 10.90; break;
                    case "Regular": price = 15; break;

                }
                
            }
            else if (dayOfTheWeek == "Saturday")
            {
                switch (typeOfGroup)
                {
                    case "Students": price = 9.80; break;
                    case "Business": price = 15.60; break;
                    case "Regular": price = 20; break;
                }
            }
            else if (dayOfTheWeek == "Sunday")
            {
                switch (typeOfGroup)
                {
                    case "Students": price = 10.46; break;
                    case "Business": price = 16; break;
                    case "Regular": price = 22.50; break;
                }
            }
            double sum = price * countOfPpl;
            if (countOfPpl >= 30 && typeOfGroup == "Students")
            {
                sum *= 0.85;
            }
            else if (countOfPpl >= 100 && typeOfGroup == "Business")
            {
                sum -= 10 * price;
            }
            else if (countOfPpl >= 10 && countOfPpl <= 20 && typeOfGroup == "Regular")
            {
                sum *= 0.95;
            }
            Console.WriteLine($"Total price: {sum:f2}");
        }
    }
}