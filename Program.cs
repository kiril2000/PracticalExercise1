using System;

namespace Bakery
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Брой дни:");
            ushort days = ushort.Parse(Console.ReadLine());
            Console.WriteLine("Брой сладкари:");
            ushort sladkari = ushort.Parse(Console.ReadLine());
            Console.WriteLine("Брой торти:");
            ushort cakes = ushort.Parse(Console.ReadLine());
            Console.WriteLine("Брой гофрети:");
            ushort gofreti = ushort.Parse(Console.ReadLine());
            Console.WriteLine("Брой палачинки:");
            ushort pancakes = ushort.Parse(Console.ReadLine());

            decimal sumOfCakes = cakes * 45;
            decimal sumOfPancakes = pancakes * 3.20m;
            decimal sumOfGofreti = gofreti * 5.80m;

            decimal sumForTheDay = (sumOfCakes + sumOfPancakes + sumOfGofreti) * sladkari;
            decimal sumOfAllMoney = sumForTheDay * days;

            decimal result = sumOfAllMoney - (sumOfAllMoney / 8);

            Console.WriteLine($"Събрани средства: {result}");


        }
    }
}