using System;

namespace P04.VegetableMarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double vegetables = double.Parse(Console.ReadLine());
            double fruits = double.Parse(Console.ReadLine());
            double kgVegetables = double.Parse(Console.ReadLine());
            double kgFruits = double.Parse(Console.ReadLine());

            kgVegetables = kgVegetables * vegetables;
            kgFruits = kgFruits * fruits;
            double final = (kgFruits + kgVegetables) / 1.94;
            Console.WriteLine($"{final:f2}");
        }
    }
}
