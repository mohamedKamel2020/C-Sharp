using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter array length");
            int l = int.Parse(Console.ReadLine());
            int[] arr = new int[l];
            enterArray(arr);
            Console.WriteLine("---------------");
            displayArray(arr);   
            Console.WriteLine("----------------");
            int total = 0;
            for (int i = 0;i < arr.Length; i++)
            {
                total+=arr[i];
            }
            Console.WriteLine("total =" + total);
            Console.WriteLine("----------------");
            Console.WriteLine("avrage ="+ total/arr.Length);
           
        }
        static void displayArray(int [] x) 
        {
            Console.WriteLine("all values");
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine(x[i]);
            }
        }
        static void enterArray(int [] y) 
        {

            
            for (int i = 0; i < y.Length; i++)
            {
                Console.WriteLine("enter value number" + (i + 1));
                y[i] = int.Parse(Console.ReadLine());
            }
        }
    }
}
