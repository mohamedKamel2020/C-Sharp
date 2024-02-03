using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[,] arr = new int[5, 2] { { 0, 0 }, { 1, 2 }, { 1, 3 }, { 1, 4 }, { 1, 5 } };
            //int i, j;
            //for (i = 0; i < 5; i++)
            //{
            //    for (j = 0; j < 2; j++)
            //    {
            //        Console.WriteLine("a[{0},{1}] = {2}", i, j, arr[i, j]);
            //    }
            //}
            Console.WriteLine("enter rows number");
            int rows=int .Parse(Console.ReadLine());

            Console.WriteLine("enter columns number");
            int cols=int .Parse(Console.ReadLine());

            
            Console.WriteLine("enter array");
            int[,] arr2 = new int[rows, cols];
            int x, y;
            for (x = 0; x < arr2.GetLength(0); x++)
            {
                for(y = 0; y < arr2.GetLength(1); y++)
                {
                    Console.WriteLine("Enter the value of [" + (x + 1) + "," + (y + 1) + "]");
                    arr2[x,y]=int.Parse(Console.ReadLine());
                }
            }
            
            
            Console.WriteLine("-----------------------------");
            Console.WriteLine("My Array");
            for (x = 0; x < arr2.GetLength(0); x++)
            {
                for (y = 0; y < arr2.GetLength(1); y++)
                {
                    Console.WriteLine("my arr2 [{0},{1}]={2}",x,y,arr2[x,y]);
                }
            }


            Console.WriteLine("-----------------------------");
            Console.WriteLine("-----------------------------");
            int sum =0;
            for (x = 0; x < arr2.GetLength(0); x++)
            {
                for (y = 0; y < arr2.GetLength(1); y++)
                {
                    sum=sum+arr2[x,y];
                }
            }
            Console.WriteLine("sum of array ="+ sum);
            Console.WriteLine("avr of array ="+(sum/arr2.Length));


            /* a jagged array of 5 array of integers*/
            int[][] a = new int[][]{new int[]{0,0},new int[]{1,2},
            new int[]{2,4},new int[]{ 3, 6 }, new int[]{ 4, 8 } };
            int i, j;

            /* output each array element's value */
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.WriteLine("a[{0}][{1}] = {2}", i, j, a[i][j]);
                }
            }
            Console.ReadKey();
        }
    }
}
