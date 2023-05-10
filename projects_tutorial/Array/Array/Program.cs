using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[10];
            int i, j;
            for (i = 0; i < 10; i++)
            {
                n[i] = i+100;
            }
            for (j = 0; j < 10; j++)
            {
                Console.WriteLine("Elements{0}={1}",j,n[j]);

            }
            int [] arr=new int[10];
            arr[0] = 10;
            arr[1] = 20;
            arr[2] = 30;
            arr[3] = 40;
            arr[4] = 50;
            arr[5] = 60;
            arr[6] = 70;
            arr[7] = 80;
            arr[8] = 90;
            arr[9] = 100;

            int[] arr2 = { 10,20,30,40,50};
            Console.WriteLine(arr[2]);
            Console.WriteLine(arr2.Length);
        }
    }
}
