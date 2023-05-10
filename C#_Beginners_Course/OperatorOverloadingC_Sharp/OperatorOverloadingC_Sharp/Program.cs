using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadingC_Sharp
{
    public class Rectangle
    {
        public int Width = 0;
        public int Height = 0;
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }
        public static Rectangle operator +(Rectangle rect1,Rectangle rect2) 
        {
            Rectangle rectResult = new Rectangle(rect1.Width + rect2.Width, rect1.Height + rect2.Height);
            return rectResult;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect3 = new Rectangle(10, 8);
            Rectangle rect4 = new Rectangle(9, 5);
           Rectangle rectResult=rect3 + rect4;
            Console .WriteLine($"'rect1(10,8)+rect2(9,5)'='rectResult({rect3.Width + rect4.Width},{rect3.Height + rect4.Height})'");
            Console.ReadKey();
        }
    }
}
