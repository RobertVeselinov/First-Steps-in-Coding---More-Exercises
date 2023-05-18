using System;

namespace P05.TrainingLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine()) * 100;
            double h = double.Parse(Console.ReadLine()) * 100;
            h = h - 100;
            double deskRow = Math.Truncate (h / 70);
            double rows =Math.Truncate (w / 120);
            double places = deskRow * rows - 3;
            Console.WriteLine(places);
        }
    }
}
