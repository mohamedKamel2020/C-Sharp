using System;

namespace _2_Array_tutorialPoint
{
    class Program
    {
        static void Main()
        {
            /*int[] n = new int[10];
             int s;
             Console.WriteLine("intput Numper");
             s = Convert.ToInt32(Console.ReadLine());

             for (int i=0;i<10;i++) {
                 n[i] = i + s;
             }
             for (j = 0; j < 10; j++)
             {
                 Console.WriteLine("Element[{0}] = {1}", j, n[j]);
             }
            foreach (int j in n)
            {
                 int i = j - s;
                Console.WriteLine("Element[{0}] = {1}", i, j);
            }
            int[,] a = new int[5, 2] { { 0, 0 }, { 1, 2 }, { 2, 4 }, { 3, 6 }, { 4, 8 } };
            int i, j;
            for (i = 0; i < 5; i++) {
                for (j = 0; j < 2; j++)
                {
                    Console.WriteLine("a[{0},{1}]={2}", i, j, a[i, j]);
                }
            }*/
            int[][] scores = new int[5][];
            for (int i = 0; i < scores.Length; i++)
            {
                scores[i] = new int[4];
            }
            int[][] scores = new int[2][] { new int[] { 92, 93, 94 }, new int[] { 85, 66, 87, 88 } };

        }
    }
}
