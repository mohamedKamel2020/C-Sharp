using System;

namespace _8_Loop_tutorialpoint
{
    class Program
    {
        static void Main(string[] args)
        {
            /*while loop*/
            Console.WriteLine("input first Number :-");
            int Num1;
            Num1 = Convert.ToInt32(Console.ReadLine());
            while (Num1 < 50)
            {
                Console.WriteLine("value Num1 is :{0}",Num1);
                Num1++;
                if (Num1>45) {
                    break;
                }
            }
            /*for_loop */
            Console.WriteLine("input second Number :-");
            int Num2;
            Num2 = Convert.ToInt32(Console.ReadLine());
            for (int i=0;i<Num2;i++) {
                if (i== 4)
                {
                    continue;
                }
                Console.WriteLine("value Num2 is :{0}",i);
            }
            Console.WriteLine("input Next Number :-");
            int Num3;
            Num3 = Convert.ToInt32(Console.ReadLine());
            /* do loop execution */
            do
            {
                Console.WriteLine("value of a: {0}", Num3);
                Num3++;
            }
            while (Num3 < 20);
            Console.ReadLine();
        }
    }
    }

