using System;

namespace PastryShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int numberChefs = int.Parse(Console.ReadLine());
            int Cakes = int.Parse(Console.ReadLine());
            int Waffles = int.Parse(Console.ReadLine());
            int Pancakes = int.Parse(Console.ReadLine());

            decimal sumForDay = (Cakes * 45.00m + Waffles * 5.80m + Pancakes * 3.20m) * numberChefs;

            decimal sum = sumForDay * days;

            Console.WriteLine($"{sum} FULLSUM={ Math.Round(sum-sum/8, 2)} BGN");

        }
    }
}
