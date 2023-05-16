namespace _11._Orders
{
    internal class program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                double capsulePrice = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsuleCount = int.Parse(Console.ReadLine());
                double priceAll = (days * capsuleCount) * capsulePrice;
                sum += priceAll;
                Console.WriteLine($"The price for the coffee is: ${priceAll:f2}");
            }
            Console.WriteLine($"Total: ${sum:f2}");
        }
    }
}