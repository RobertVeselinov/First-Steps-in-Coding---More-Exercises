using System;

namespace P06.Fishland
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double mackerel = double.Parse(Console.ReadLine());
            double sprat = double.Parse(Console.ReadLine());
            double kgBonito = double.Parse(Console.ReadLine());
            double kgSafrid = double.Parse(Console.ReadLine());
            double kgMussels = double.Parse(Console.ReadLine()) * 7.50;

            double palamudPricePerKg = mackerel + mackerel * 0.60;
            double sumPalamud = palamudPricePerKg * kgBonito;
            double safridPricePerKg = sprat + sprat * 0.80;
            double sumSafrid = safridPricePerKg * kgSafrid;
            double final = kgMussels + sumPalamud + sumSafrid;
            Console.WriteLine($"{final:f2}");
        }
    }
}
