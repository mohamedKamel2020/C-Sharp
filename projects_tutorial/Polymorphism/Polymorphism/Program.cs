using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Program
    {
        class printData
        {
            //function overloading
            public void print(int i)
            {
                Console.WriteLine("int = {0}",i);
            }
            public void print(double d)
            {
                Console.WriteLine("double = {0}", d);
            }
            public void print(string s)
            {
                Console.WriteLine("string = {0}", s);
            }
        }
        static void Main(string[] args)
        {
            printData p=new printData();
            p.print(100);
            p.print(10.2);
            p.print("mohamed kamel");
        }
    }
}
