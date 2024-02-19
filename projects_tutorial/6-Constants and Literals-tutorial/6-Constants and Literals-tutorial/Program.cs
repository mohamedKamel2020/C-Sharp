using System;

namespace _6_Constants_and_Literals_tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 10;
            double r;
            r = Convert.ToDouble(Console.ReadLine());
            double areaCircle = pi * r * r;
            Console.WriteLine("Radius: {0}, Area: {1}", r, areaCircle);
            Console.ReadLine();

        }
    }
}
