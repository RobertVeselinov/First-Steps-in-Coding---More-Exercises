using System;

namespace P07.HousePainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double frontSides = x * x * 2 - 2.4;
            double lateralSides = y * x * 2 - 4.5;
            double sumWalls = frontSides + lateralSides;
            double rectangle = x * y * 2;
            double triangle = x * h / 2 * 2;
            double sumTriangle = rectangle + triangle;
            double greenPaint = sumWalls / 3.4;
            double redPaint = sumTriangle / 4.3;
            Console.WriteLine($"{greenPaint:f2}");
            Console.WriteLine($"{redPaint:f2}");
        }
    }
}
