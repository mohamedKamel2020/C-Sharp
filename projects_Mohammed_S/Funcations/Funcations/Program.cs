using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("addition");
            Console.WriteLine("------------------");
            add();
            Console.WriteLine("substrction");
            Console.WriteLine("------------------");
            sub();
            Console.WriteLine("multiplction");
            Console.WriteLine("------------------");
            multiplction();
            Console.ReadLine();

        }
        static void add()
        {
            Console.WriteLine("Enter first number");
            int x=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine(x+y);
        }
        static void sub()
        {
            Console.WriteLine("Enter first number");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine(x - y);
        }
        static void multiplction()
        {
            Console.WriteLine("Enter first number");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine(x * y);
        }

    }
}
