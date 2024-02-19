using System;

namespace _7_Decision_Making_tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //if_statement_else
            Console.WriteLine("input Number:-");
            int a;
            a = Convert.ToInt32(Console.ReadLine());
            if (a<20) {
                Console.WriteLine("a is less than 20");
            }
            else if (a == 20)
            {
              
                Console.WriteLine(" a is = 20");
            }
            else
            {
                // if condition is false 
                Console.WriteLine("a is not less than 20");
            }
            Console.WriteLine("value of a is : {0}", a);
            int n;
            int b;
            Console.WriteLine("input fNum");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input sNum");
            b = Convert.ToInt32(Console.ReadLine());
            if (n<20) {
                if (b < 40)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
            else
            {
                Console.WriteLine("false");
            }
            Console.WriteLine("Exact value of a is : {0}", a);
            Console.WriteLine("Exact value of b is : {0}", b);
        }
    }
}