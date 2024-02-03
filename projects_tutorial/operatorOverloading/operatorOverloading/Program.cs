using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatorOverloading
{
    class Box
    {
        private double length;
        private double height;
        private double breadth;
        public double getVolume()
        {
            return length * height * breadth;
        }
        public void setLength(double len)
        {
            length = len;
        }
        public void setBreadth(double bre)
        {
            breadth = bre;
        }
        public void setHeight(double hei ) 
        { 
            height = hei; 
        }    
        // Overload + operator to add two obj
        public static Box operator+ (Box b, Box c)
        {
            Box box = new Box();
            box.length= b.length+c.length;
            box.height= b.height+c.height;
            box.breadth= b.breadth+c.breadth;
            return box;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Box Box1=new Box();//declare object Box1 of class Box
            Box Box2=new Box();//---------------Box2------------
            Box box3=new Box();//---------------Box3--------------
            Box totalBox=new Box();
            Box1.setLength(5);
            Box2.setLength(10);
            Box1.setBreadth(15);
            Box1.setHeight(10);
            Box2.setHeight(15);
            Box2.setBreadth(5);
            double volume = Box1.getVolume();
            Console.WriteLine("Volume of Box1 : {0}", volume);

            volume = Box2.getVolume();
            Console.WriteLine("Volume of Box2 : {0}", volume);
            box3 = Box1 + Box2;
            volume = box3.getVolume();
            Console.WriteLine("volume so box 3 : {0}",volume);
            totalBox = Box1 + box3 + Box2;
            volume=totalBox.getVolume();
            Console.WriteLine("Total boxs :{0}",volume);
            Console.ReadKey();
        }

    }
}
