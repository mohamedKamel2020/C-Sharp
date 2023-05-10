using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsC_Sharp
{
    internal class Program
    {
        static void doWhileLoop()
        {
            int x = 0;
            const int maxCount = 10;
            do
            {
                Console.WriteLine($"the value of 'x' is {x}");
                x++;
            }
            while (x < maxCount);
        }
        static void doWhileLoopBreak()
        {
            int x = 0;
            const int maxCount = 10;
            Console.WriteLine("Before loop");
            do
            {
                if (x == 4)
                {
                    break;
                }
                Console.WriteLine($"the value of 'x' is {x}");
                x++;

            } while (x<maxCount);
            Console.WriteLine("After loop");
        }
        static void whileLoop()
        {
            int x = 0;
            const int maxCount = 10;
            while (x<maxCount) 
            {
                Console.WriteLine($"the value 'x' is{x}");
                x++;
            }
        }
        static void whileLoopContinue()
        {
            int x = 0;
            const int maxCount = 10;
            while (x < maxCount)
            {
                if(x == 4)
                {
                    x++;
                    continue;
                  
                }
                Console.WriteLine($"the value of 'x' is {x}");
                x++;
            }
        }
        static void forLoop()
        {
            const int maxCount = 10;
            for (int x=0;x<maxCount;x++) 
            {
                Console.WriteLine($"the value of 'x' is {x}");
            }
        }
        static void nestedForLoop()
        {
            const int maxParentLoopCount = 10;
            const int maxChildLoopCount = 5;
            for (int x=0;x<maxParentLoopCount;x++) 
            {
                Console.Write($"{x}: ");
                for (int y=0;y<maxChildLoopCount;y++)
                {
                    Console.Write($"{y}");
                }
                Console.WriteLine();
            }
        }
        static void NestedForLoopChildLoopDecrement()
        {
            const int maxParentLoopCount = 10;
            const int maxChildLoopCount = 5;

            for (int x = 0; x < maxParentLoopCount; x++)
            {
                Console.Write($"{x}: ");
                for (int y = maxChildLoopCount - 1; y > -1; y--)
                {
                    Console.Write($"{y} ");
                }
                Console.WriteLine();
            }

        }
        static void Main(string[] args)
        {

            ForEachExample();

            Console.ReadKey();

        }

        static void ForEachExample()
        {
            Car[] cars = new Car[] { new Car(200, "Car 1"), new Car(180, "Car 2"), new Car(240, "Car 3"), new Car(300, "Car 4") };

            foreach (iCar car in cars)
            {
                Console.WriteLine($"{car.CarLabel} has a maximum speed of {car.GetMaxSpeed()}");
            }

        }


        public interface iCar
        {
            float GetMaxSpeed();
            string CarLabel { get; set; }
        }

        public class Car : iCar
        {
            float _maxSpeed = 0;
            string _carLabel = string.Empty;

            public Car(float maxSpeed, string carLabel)
            {
                _maxSpeed = maxSpeed;
                _carLabel = carLabel;
            }

            public string CarLabel
            {
                get
                {
                    return _carLabel;
                }
                set
                {
                    _carLabel = value;
                }
            }
            public float GetMaxSpeed()
            {
                return _maxSpeed;
            }
        }
    }
}
