using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    //base class
    class rectangle
    {
        //member var
        protected double x;
        protected double y;
        //constructor
        public rectangle(double X, double Y)
        {
            x = X;
            y = Y;
        }
        public double GetArea()
        {
            return x * y;
        }
        public void Display()
        {
            Console.WriteLine("Length = {0} ", x);
            Console.WriteLine("Width  = {0} ", y);
            Console.WriteLine("Area   = {0} ", GetArea());

        }

    }
    //drived class
    class Tabletop : rectangle
    {
        private double cost;
        //constructors
        public Tabletop(double X,double Y):base(X, Y)
        {
            
        }
        public double GetCost()
        {
            double cost ;
            cost=GetArea()*70;
            return cost;
        }
        public void Display()
        {
            base.Display();
            Console.WriteLine("cost:{0}", GetCost());
        }
    }
    //base class
    //class shape
    //{
    //    public void setWidth(int w)
    //    {
    //        width = w;
    //    }
    //    public void setHeight(int h)
    //    {
    //        height = h;
    //    }
    //    protected int width;
    //    protected int height;
    //}
    //drived class
    //class Rectangle : shape
    //{
    //    public int getArea()
    //    {
    //        return (width * height);
    //    }
    //}
    internal class Program
    {
        static void Main(string[] args)

        {
        //    Rectangle rect =new Rectangle();
        //    rect.setWidth(10);
        //    rect.setHeight(7);
        //    Console.WriteLine("Total area :{0}",rect.getArea());
        Tabletop t = new Tabletop(4.5, 7.5);
        t.Display();
        Console.ReadLine();
        Console.ReadKey();
        }
    }
}
