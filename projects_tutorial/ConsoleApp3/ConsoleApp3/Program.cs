#define var1
#undef var2
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    //Preorocesser directives
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("var1 \e define");

#if (var1 && var2)
                      Console.WriteLine("varibles are define");
#elif (var1 && !var2)
            Console.WriteLine("var1 is define");
#elif(!var1 && var2)
            Console.WriteLine("var2 is define");
#else
            Console.WriteLine("variables are undefine");
#endif
        }
    }
}
