using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousCSharp
{
    public delegate void Print1(int value);
    public delegate void Print(int value);
    public class Program
    {
        public static void PrintHelperMethod(Print printDel, int val)
        {
            val += 100;
            printDel(val);
        }
        static void Main(string[] args)
        {
            int i = 10;
            Print1 print1 = delegate (int val) {
                val += i;
                Console.WriteLine("Inside Anonymous method. Value: {0}", val);
            };

            print1(100);
            PrintHelperMethod(delegate (int val) { Console.WriteLine("Anonymous method: {0}", val); }, 100);

        }
    }
}
