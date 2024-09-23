using System;
namespace Watermelon
{
    class Program
    {
        static void Main(string[] args)
        {
            int w;
           
            do {
                
                w = Convert.ToInt32(Console.ReadLine());
                if (w >= 1 && w <= 100)
                    break;
            } while (true);
            if (w % 2 == 0&&w>2)
            {
                    Console.WriteLine("Yes");
            }
            else
            {
                    Console.WriteLine("No");
            }
        }
    }
}