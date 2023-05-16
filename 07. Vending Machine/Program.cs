namespace _07._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = (Console.ReadLine());
            double currentSum = 0;
            while (input != "Start")
            {
                double coin = double.Parse(input);
                switch (coin)
                {
                    case 0.2: currentSum += coin; break;
                    case 0.1: currentSum += coin; break;
                    case 0.5: currentSum += coin; break;
                    case 1: currentSum += coin; break;
                    case 2: currentSum += coin; break; 
                    default:Console.WriteLine($"Cannot accept {coin}");break;
                }
                input = Console.ReadLine();
            }
            string product = Console.ReadLine();
            while (product != "End")
            {
                double productCost = 0;
                switch (product)
                {
                    case "Nuts": productCost = 2; break;
                    case "Water": productCost = 0.7; break;
                    case "Crisps": productCost = 1.5; break;
                    case "Soda": productCost = 0.8; break;
                    case "Coke": productCost = 1; break;
                    default:Console.WriteLine($"Invalid product"); break;
                        
                }
                if (currentSum >= productCost && currentSum > 0 && productCost > 0)
                {
                    currentSum -= productCost;
                    Console.WriteLine($"Purchased {product.ToLower()}");
                }
                else if (productCost > 0)
                {
                    Console.WriteLine($"Sorry, not enough money");
                }
                product = Console.ReadLine();
            }
            Console.WriteLine($"Change: {currentSum:f2}");
        }
    }
}