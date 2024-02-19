using System;

/*namespace _14_Class_tutorial
{
    using System;

    /*namespace GeeksforGeeks
    {

        class Complex
        {

            // Class members, private 
            // by default
            int real, img;

            // Defining the constructor
            public Complex()
            {
                real = 0;
                img = 0;
            }

            // SetValue method sets 
            // value of real and img
            public void SetValue(int r, int i)
            {
                real = r;
                img = i;
            }
            public void DisplayValue()
            {
                Console.WriteLine("Real = " + real);
                Console.WriteLine("Imaginary = " + img);
            }

            // Defining the destructor
            // for class Complex
            ~Complex()
            {
                Console.WriteLine("Destructor was called");
            }

        } // End class Complex
        class Program
        {

            // Main Method
            static void Main(string[] args)
            {

                // Creating an instance of class 
                // Complex C invokes constructor
                Complex C = new Complex();

                // Calling SetValue method using
                // instance C Setting values of 
                // real to 2 and img to 3
                C.SetValue(2, 3);

                // Displaying values of real
                // and imaginary parts
                C.DisplayValue();

                // Instance is no longer needed

            }
        }
    }
}
            /*class Box
            {
                public Box()
                {
                    Console.WriteLine("Object is being created");
                }
                ~ Box ()
                {   
                    Console.WriteLine("Object is being deleted");
                }
                public double length;   
                public double breadth;  
                public double height;   
            }
            class Program
            {
                ~Program()
                {
                    Console.WriteLine("Object is being deleted");
                }
                static void Main(string[] args)
                {
                    Program e = new Program();
                    Box Box1 = new Box();
                    Box Box2 = new Box();
                    double volume = 0.0;
                    Console.WriteLine("Input Height Box1");
                    Box1.height = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Input Length Box1");
                    Box1.length = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Input breadth Box1");
                    Box1.breadth = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Input Height Box2");
                    Box2.height = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Input Length Box2");
                    Box2.length = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Input Breadth Box2");
                    Box2.breadth = Convert.ToDouble(Console.ReadLine());

                    volume = Box1.height * Box1.length * Box1.breadth;
                    Console.WriteLine("Volume of Box1 :-{0}",volume);
                    volume = Box2.height * Box2.length * Box2.breadth;
                    Console.WriteLine("Volume of Box2 : {0}", volume);
                    Console.ReadKey();
                }
            }
namespace GeeksforGeeks
{

    public class Vect
    { 
        double i, j, k;

        public Vect()
        {
            i = 0.0;
            j = 0.0;
            k = 0.0;
            Console.WriteLine("An instance of " +
                          "Vect class created");
        }

    
        public void SetVector(double iComponent, double jComponent,
                          double kComponent)
        {
            i = iComponent;
            j = jComponent;
            k = kComponent;
        }

     
        public double FindMagnitude()
        {
            double m = 0.0;
            m = Math.Sqrt(i * i + j * j + k * k);
            return m;
        }

        ~Vect()
        {
            Console.WriteLine("The instance of" +
                      " Vect class Destroyed");
        }

    } 
    class Procedure
    {

        static void Main(string[] args)
        {
            Vect V1 = new Vect();

            V1.SetVector(2.3, -1.5, 7.0);

            Console.WriteLine("Magnitude of the vector " +
                "2.3i-1.5j+7k is " + V1.FindMagnitude());      
        }

    } 

}
namespace LineApplication
{
    class Line
    {
        private double length;  

        public Line()
        {  
            Console.WriteLine("Object is being created");
        }
        ~Line()
        {   
            Console.WriteLine("Object is being deleted");
        }
        public void setLength(double len)
        {
            length = len;
        }
        public double getLength()
        {
            return length;
        }
        static void Main(string[] args)
        {
            Line line = new Line();

            line.setLength(6.0);
            Console.WriteLine("Length of line : {0}", line.getLength());
        }
    }
}*/
namespace StaticVarApplication
{
    class StaticVar
    {
        public static int num=4;
        public void count()
        {
            num++;
        }
        public int getNum()
        {
            return num;
        }
    }
    class StaticTester
    {
        static void Main()
        {
            StaticVar s1 = new StaticVar();
            StaticVar s2 = new StaticVar();
            s1.count();
            s1.count();
            s1.count();
            
            s2.count();
            s2.count();
            s2.count();
            Console.WriteLine("Variable num for s1: {0}", s1.getNum());
            Console.WriteLine("Variable num for s2: {0}", s2.getNum());
            Console.ReadKey();
        }
    }
}
