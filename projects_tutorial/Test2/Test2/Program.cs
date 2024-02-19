using System;

namespace test1
{
    class Program
    {
        static void Main()
        {
            int celsius = 30;

            int kelvin;
            int fahrenheit;
            kelvin = celsius + 273;
            Console.WriteLine("kelvin=" + kelvin);
            fahrenheit = celsius *18 / 10 +32;
            Console.WriteLine("fahrenheit=" + fahrenheit);
        }
    }
}
