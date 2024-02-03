using System;
/*namespace rectangleApp
{
    class rectangle
    {
        double length;
        double width;
        public void values() { length = 4.5; width = 3;}
        public double getArea() { return length*width; }
        public void display()
        {
            Console.WriteLine("Length:{0}", length);
            Console.WriteLine("Width:{0}", width);
            Console.WriteLine("Area:{0}", getArea());
        }
    }
    class executeRectangle
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("size of int :{0}",sizeof(int));
            rectangle r = new rectangle();
            r.values();
            r.display();
            Console.ReadLine();
        }
    }
}
*/
namespace typeConversion
{
    class typeConversion
    {
        static void Main()
        {
            int x = 20;
            float y = 10.002f;
            double z = 10.2883;
            bool d = true;
            int a=10;
            int b=20;
            int c;

            Console.WriteLine(x.ToString());
            Console.WriteLine(y.ToString());
            Console.WriteLine(z.ToString());
            Console.WriteLine(d.ToString());
            c = a + b;
            Console.WriteLine("Line 1 Value of c is {0}",c);
            c = a - b;
            Console.WriteLine("Line 2 Value of c is {0}", c); 
            c = a * b;
            Console.WriteLine("Line 3 Value of c is {0}", c); 
            c = a % b;
            Console.WriteLine("Line 4 Value of c is {0}", c); 
            c = a / b;
            Console.WriteLine("Line 5 Value of c is {0}", c);
            c = a++;
            Console.WriteLine("Line 6 Value of c is {0}", c);
            c = a--;
            Console.WriteLine("Line 7 Value of c is {0}", c);
            int m=10;
            int n=20;
            if (m == n)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            if (m == n)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            if (m != n)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            if (m > n)
            {
                Console.WriteLine("true");

            }
            else
            {
                Console.WriteLine("false");
            }
            if (m < n)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            if (m >= n)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            if (m <= n)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}