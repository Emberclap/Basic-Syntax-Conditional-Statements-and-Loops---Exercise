namespace _10._Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            int trashedHeadsets = lostGamesCount / 2;
            int trashedMauses = lostGamesCount / 3;
            int trashedKeyboards = lostGamesCount / 6;
            int trashedDisplays = lostGamesCount / 12;
            double rageExpenses = (trashedDisplays * displayPrice) + (trashedHeadsets * headsetPrice) +
                (trashedMauses * mousePrice) + (trashedKeyboards * keyboardPrice);
            Console.WriteLine($"Rage expenses: {rageExpenses:f2} lv.");

        }
    }
}