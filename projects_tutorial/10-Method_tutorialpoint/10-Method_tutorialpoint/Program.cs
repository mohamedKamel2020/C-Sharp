using System;

namespace _10_Method_tutorialpoint
{
    class FindMax
    {
        public int Num1;
        public int Num2;
        public void Recepion()
        {
            Console.WriteLine("Enter First Number ");
            Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second Number ");
            Num2 = Convert.ToInt32(Console.ReadLine());
        }
        public void result()
        {
            Console.WriteLine("result=");
            if (Num1 > Num2)
                Console.WriteLine(Num1);
            else
                Console.WriteLine(Num2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            FindMax f = new FindMax();
            f.Recepion();
            f.result();
        }
    }
}
