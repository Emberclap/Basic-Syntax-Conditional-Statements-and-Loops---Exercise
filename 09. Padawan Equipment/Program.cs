namespace _09._Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double johnMoney = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double singleSaberPrice = double.Parse(Console.ReadLine());
            double singleRobePrice = double.Parse(Console.ReadLine());
            double singleBeltPrice = double.Parse(Console.ReadLine());
            double sabersPrice = (Math.Ceiling(studentsCount * 1.10)) * singleSaberPrice;
            double robesPrice = studentsCount * singleRobePrice;
            double beltPrice = studentsCount * singleBeltPrice;
            int freeBelts = studentsCount / 6;
            if (freeBelts > 0)
            {
                beltPrice -= freeBelts * singleBeltPrice;
            }

            double moneyNeed = beltPrice + robesPrice + sabersPrice;
            if (johnMoney >= moneyNeed)
            {
                Console.WriteLine($"The money is enough - it would cost {moneyNeed:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {moneyNeed - johnMoney:f2}lv more.");
            }
        }
    }
}