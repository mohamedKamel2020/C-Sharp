using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepitionCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("enter number");
                int num = Convert.ToInt32(Console.ReadLine());

            }
            catch (Exception s)
            {
                Console.WriteLine(s.Message);

            }
            Console.ReadKey();
        }
    }
}
