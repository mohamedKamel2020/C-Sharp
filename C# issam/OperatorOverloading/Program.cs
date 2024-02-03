using System;

namespace OperatorOverloading
{
    class box 
    {
        private double length;
        private double breadth;
        private double height;

        public double getVolume()
        {
            return length*breadth*height;
        }
        public void setLength(double len)
        {
            length = len;
        }
        public void setBreadth(double bre)
        {
           breadth= bre;    
        }
        public void setHeight(double hei)
        {
            height = hei;
        }
        // Overload + operator 
        public static box operator+(box b, box c)
        {
            box box1= new box();
            box1.length = b.length + c.length;
            box1.breadth = b.breadth + c.breadth;
            box1.height = b.height + c.height;
            return box1;
        }
        public static bool operator == (box lhs, box rhs)
        {
            bool status = false;
            if (lhs.length == rhs.length && lhs.height == rhs.height
               && lhs.breadth == rhs.breadth)
            {

                status = true;
            }
            return status;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
   

}
