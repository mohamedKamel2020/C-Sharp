using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter first Number :");
                int Num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter second Number :");
                int Num2 = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("finally!!........");
            }
            Console.WriteLine("the end!!!........");
            Console.WriteLine("enter your temp");
            int temp=int.Parse(Console.ReadLine());
            if (temp > 50)
            {
                Console.WriteLine("ohhhhhhhh!!! God");
                throw new Exception("you are dead Hhhhhhhhhhhhhhh");
            }
        }
    }
}
