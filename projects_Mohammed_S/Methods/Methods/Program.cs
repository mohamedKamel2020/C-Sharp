using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            int b = 20;

            add(out a,ref b);
            Console.WriteLine(a + " -------------" + b);
            add(20, 20.2);
            add(20, 10, 20);
            int? n1 = null;
            int? n2 = 3;
            int? n3;
            n3 = n1 ?? 5;
            Console.WriteLine(n3);
            n3 = n2 ?? 5;
            Console.WriteLine(n3);

            
        }
        // Methods overloading 
        static void add(out int Num1,ref int Num2)
        {
            Num2 = 5;
            Num1 = 10;
            Console.WriteLine(Num1+Num2);
        }
        static void add(double Num1, double Num2)
        {
            Console.WriteLine(Num1 + Num2);

        }
        static void add(int Num1, int Num2,int Num3)
        {
            Console.WriteLine(Num1 + Num2+Num3);
        }
    }
}
