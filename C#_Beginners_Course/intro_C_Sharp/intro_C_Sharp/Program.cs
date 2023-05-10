 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intro_C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plese enter your name ");
            string name = "";
            name=Console.ReadLine();
            Console.WriteLine($"Hello {name}");
            Console.ReadKey();

        }
    }
}
