using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x=10;
            while (x < 20)
            {
                Console.WriteLine("the value x is :{0}",x);
                x++;
            }
            for (int a=10;a<20;a++) 
            {
                Console.WriteLine("the value a is :{0}",a);
            }
            
            int b = 10;
            do
            {
                if (b == 15)
                {
                    /* skip the iteration */
                    b = b + 1;
                    continue;
                }
                Console.WriteLine("the value b is :{0}", b);
                b++;
            } while (b<20);
            for (; ; )
            {
                Console.WriteLine("Hey! I am Trapped");
            }
            Console.ReadLine();
        }
    }
}
