using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedC_Session01.Generics
{
    //Generic Class

    internal class Helper<T> where T : IComparable<T> 
        //T must be struct or class and implementing Icomparable interface
    {
        #region Generic Search
        public static void BubbleSort(T[] arr)
        {
            for (int i=0;i<arr?.Length;i++)
            {
                for(int j = 0; j < arr?.Length - i - 1; j++)
                {
                    if (arr[j].CompareTo( arr[j + 1])==1)
                    {
                        Swap(ref arr[j],ref arr[j + 1]);
                    }
                }
            }
        }
        //Generic Method
        public static int SearchArray(T[] Arr,T Value)
        {
            for (int i = 0; i < Arr.Length; i++)
            {
                if (Value.Equals(Arr[i]))
                    return i;
            }    
            return -1;
        }

        #endregion

        #region Generic Swap
        //Generic Method
        public static void Swap(ref T X, ref T Y)
        {
            T temp = X;
            X = Y;
            Y = temp;
        }
        //Generic Method
        //public static void Swap<T>(ref T X, ref T Y)
        //{
        //    Console.WriteLine("==== SWAP =====");
        //    T temp = X;
        //    X = Y;
        //    Y = temp;
        //}
        #endregion

        #region Non-Generics Swap
        //public static void Swap(ref int X,ref int Y)
        //{
        //    Console.WriteLine("==== SWAP =====");
        //    int temp = X;
        //    X = Y;
        //    Y = temp;
        //}

        //public static void Swap(ref double X, ref double Y)
        //{
        //    Console.WriteLine("==== SWAP =====");
        //    double temp = X;
        //    X = Y;
        //    Y = temp;
        //}
        //public static void Swap(ref Point X, ref Point Y)
        //{
        //    Console.WriteLine("==== SWAP =====");
        //    Point temp = X;
        //    X = Y;
        //    Y = temp;
        //}

        #endregion
    }
}
