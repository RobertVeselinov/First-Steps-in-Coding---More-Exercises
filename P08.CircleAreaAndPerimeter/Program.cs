using System;

namespace P08.CircleAreaAndPerimeter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double d = 2 * r;
            double p = 2 * Math.PI * r;
            double s = Math.PI * r * r;
            Console.WriteLine($"{s:f2}");
            Console.WriteLine($"{p:f2}");

        }
    }
}
