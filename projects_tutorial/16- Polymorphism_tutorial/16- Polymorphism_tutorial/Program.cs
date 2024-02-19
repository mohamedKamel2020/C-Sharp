/*using System;

namespace _16__Polymorphism_tutorial
{
    abstract class Shape
    {
        public abstract int area();
    }
    class Rectangle : Shape
    {
        private int length;
        private int width;
        public Rectangle(int a=0,int b=0)
        {
            length = a;
            width = b;
        }
        public override int area()
        {
            Console.WriteLine("Rectangle class area :");
            return (width * length);
        }
    }
    class program
    {
        static void Main()
        {
            Rectangle r = new Rectangle(10, 7);
            double a = r.area();
            Console.WriteLine("Area:{0}", a);
        }
    }
    class Program
    {
        void print(int i)
        {
            Console.WriteLine("Printing int = {0}",i);
        }
        void print(double f)
        {
            Console.WriteLine("Printing float = {0}", f);
        }
        void print(string s)
        {
            Console.WriteLine("Printing string = {0}", s);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.print(5);
            p.print(500.234);
            p.print("Hello C#");
            Console.ReadKey();
        }
    }
}
using System;
namespace Studytonight
{
    public class Interest
    {
        //static polymorphism
        // interest for 1 year of tenure
        public double TrueBank(double amount, double rate)
        {
            return amount + (amount * rate);
        }
        public double TrueBank(double amount, double rate, string holdertype)
        {
            return amount + (amount * rate) + 2000;
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Interest i = new Interest();

            double finalamount = i.TrueBank(5000.00, 0.1);
            Console.WriteLine("Normal interest for a holder " + finalamount);

            finalamount = i.TrueBank(5000.00, 0.1, "prime");
            Console.WriteLine("Prime interest for a holder " + finalamount);

        }
    }
}*/

