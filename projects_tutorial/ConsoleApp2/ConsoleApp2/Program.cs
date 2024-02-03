using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class staticVar
    {
        public static int num;
        public void count()
        {
            num++;
        }
        public  int getNum()
        {
            return num;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            staticVar s1=new staticVar();
            staticVar s2=new staticVar();
            s1.count();
            s1.count();
            s1.count();
            s1.count();
            s1.count();

            s2.count();
            Console.WriteLine("Variable num for s1: {0}", s1.getNum());
            Console.WriteLine("Variable num for s2: {0}", s2.getNum());
            Console.ReadKey();
        }
    }
}
