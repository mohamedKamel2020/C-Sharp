using System;

namespace day2Test1
{
    /*class Program
    {
        static void Main()
        {
         
          
            Console.Write("input first number = ");
            int firstNum =Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("" + firstNum);
            Console.Write("input second number = ");
            int secondNum =Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("" + secondNum);
            if ((firstNum%2==0)&&(secondNum%2==0)) {
                Console.WriteLine("true");
            }
            else if ((firstNum % 2 != 0) && (secondNum % 2 != 0)) {
                Console.WriteLine("false");
            }
            else
            {
                Console.WriteLine("they are diffrent");
            }


           
        }
    }
    class program {
        static void Main()
        {
            Console.WriteLine("input first triangle");
            int x=Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("input second triangle");
            int y= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input third triangle");
            int z= Convert.ToInt32(Console.ReadLine());
            if (((x==y)&&(x!=z))||((x==z) && (x != y)) ||((z==y) && (z != x)))
            {
                Console.WriteLine("This is an isosceles triangle");
            }
            else if ((x==y)&&(x==z)) {
                Console.WriteLine("This is an Equilateral triangle");
            }
            else if((x!=y)&&(x!=z)&&(y!=z)){
                Console.WriteLine("This is an scalene triangle");
            }

        }


    }*/
    class program
    {
        static void Main()
        {

            
            Console.WriteLine("input number");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i=1;i<=n;i++) {
                 for(int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");

            }
        }
    }
}
