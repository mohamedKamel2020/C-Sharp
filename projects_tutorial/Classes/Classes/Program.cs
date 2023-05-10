using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Box
    {
        public Box()
        {
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("constructor-- is special member function of classe has the name of classe\n " +
                " ,dosen't have return type and excuted when you creat a new classe of your classes");
            Console.WriteLine("-----------------------------------------------------------------------------");

        }
        private double length;
        private double height;
        private double breadth;
        public void setLength(double len)
        {
            length = len;
        }
        public void setHeight(double hei)
        {
            height = hei;
        }
        public void setBreadth(double bre)
        {
            breadth = bre;
        }
        public double getVolume() 
        { 
            return length*height*breadth; 
        }
    }
    class constructors
    {
        public constructors()
        {

            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("constructor-- is special member function of classe has the name of classe\n " +
                " ,dosen't have return type and excuted when you creat a new classe of your classes");
            Console.WriteLine("-----------------------------------------------------------------------------");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Box box1=new Box();//declare box1 of type Box
            Box box2=new Box();//declare box2 of type Box

            double volume = 0.0;
            box1.setHeight(2.0);
            box1.setLength(2.0);
            box1.setBreadth(2.0);
           
            box2.setHeight(1.0);
            box2.setLength(4.0);
            box2.setBreadth(3.0);

            volume = box1.getVolume();
            Console.WriteLine("Volume of Box1=:{0}",volume);
            
            volume = box2.getVolume();
            Console.WriteLine("Volume of Box2=:{0}", volume);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("**********************************************************");
            Console.WriteLine("**********************************************************");
            Console.WriteLine("**********************************************************");

            constructors con1 = new constructors();


            Console.ReadKey();
        }
    }
}
