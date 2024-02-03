using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decision_Making
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            if (a<20) 
            {
                Console.WriteLine("a is less than 20");
            }
            else
            {
                Console.WriteLine("a is not less than 20");
            }
            Console.WriteLine("a = {0}",a);
            int x = 100;
            int y = 200;
            if (x == 100)
            {
                if (y == 200)
                {
                    Console.WriteLine("a==100 && b==200");
                }
            }
            char grade = 'F';
            switch (grade)
            {
                case 'A':
                    Console.WriteLine("Excellent");
                        break;
                case 'B':
                    Console.WriteLine("very good");
                    break;
                case 'c':
                    Console.WriteLine("Well done");
                    break;
                case 'd':
                    Console.WriteLine("you are passed");
                    break;
                case 'F':
                    Console.WriteLine("you are failled");
                    break;
                default:
                    Console.WriteLine("Invalid grade");
                    break;
            }
            int t = 10;
            int o = (t == 10) ? 20 : 30;
            Console.WriteLine(o);
            int d = (t == 1) ? 20 : 30;
            Console.WriteLine(d);

            Console.ReadLine();

        }
    }
}
