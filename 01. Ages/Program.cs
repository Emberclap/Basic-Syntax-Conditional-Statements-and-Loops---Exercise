namespace _01._Ages
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int age = int.Parse(Console.ReadLine());
            string personIs = "";
            if (age >= 0 && age <= 2)
            {
                personIs = "baby";
            }
            else if (age >= 3 && age <= 13)
            {
                personIs = "child";
            }
            else if (age >= 14 && age <= 19)
            {
                personIs = "teenager";
            }
            else if (age >= 20 && age <= 65)
            {
                personIs = "adult";
            }
            else if (age >= 66)
            {
                personIs = "elder";
            }
            Console.WriteLine(personIs);
        }
    }
}