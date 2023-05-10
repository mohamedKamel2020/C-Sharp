using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
     class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            int b = 200;
            int ret;
            //Program n=new Program();
            //ret = n.findMax(a,b);
            //Console.WriteLine(ret);
            findMax(a, b);
            Console.ReadLine();
        }
        static void findMax(int Num1,int Num2) 
        {
            int result;
            if (Num1 > Num2)
                result = Num1;
            else
                result = Num2;
            Console.WriteLine(result);
        }
    }
}
