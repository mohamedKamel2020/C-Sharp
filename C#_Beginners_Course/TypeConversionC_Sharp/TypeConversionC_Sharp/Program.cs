using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversionC_Sharp
{
    internal class Program
    {
        public struct ImperialMeasurement
        {
            public float feet;
            public ImperialMeasurement(float r)
            {
                this.feet = r;
            }
            public static explicit operator ImperialMeasurement(int m)
            {
                float conversionResult = 3.28f * m;
                ImperialMeasurement temp = new ImperialMeasurement(conversionResult);
                return temp;
            }
        }
        static void Main(string[] args)
        {
                Console.WriteLine("please enter a whole number measurement in meters");
                int mm =Convert.ToInt32(Console.ReadLine());
                ImperialMeasurement im =  (ImperialMeasurement)mm;
                Console.WriteLine($"the measurement of {mm} in meters is {im.feet} in feet ");
            Console.ReadKey();
        }
    }
}
