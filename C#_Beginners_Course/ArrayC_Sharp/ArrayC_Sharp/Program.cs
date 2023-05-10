using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayC_Sharp
{
    internal class Program
    {
        static void oneDimArray()
        {
            int[] grades = new int[8];
            grades[0] = 48;
            grades[1] = 59;
            grades[2] = 90;
            grades[3] = 72;
            grades[4] = 62;
            grades[5] = 83;
            grades[6] = 78;
            grades[7] = 59;
            writeOneDimArray(grades);
        }
        static void writeOneDimArray(int[] array)
        {
            for (int count=0;count<=array.Length-1;count++) 
            {
                Console.WriteLine($"grades[{count}] = {array[count]}");
            }
        }
        static void twoDimArray()
        {
            int[,] studentGradesPerYear = new int[4, 3];
            studentGradesPerYear[0, 0] = 50;
            studentGradesPerYear[0, 1] = 50;
            studentGradesPerYear[0, 2] = 50;

            studentGradesPerYear[1, 0] = 60;
            studentGradesPerYear[1, 1] = 60;
            studentGradesPerYear[1, 2] = 60;

            studentGradesPerYear[2, 0] = 70;
            studentGradesPerYear[2, 1] = 70;
            studentGradesPerYear[2, 2] = 70;

            studentGradesPerYear[3, 0] = 80;
            studentGradesPerYear[3, 1] = 80;
            studentGradesPerYear[3, 2] = 80;
            writeTwoDimArray(studentGradesPerYear);
        }
        static void writeTwoDimArray(int[,] array)
        {
            for (int x=0;x<=array.GetLength(0)-1;x++)
            {
                int d = x + 1;
                Console.Write($"subject[{x+1}]\t");

                for(int y = 0; y <= array.GetLength(1) - 1; y++)
                {
                    Console.Write($"{array[x,y]}\t");
                }
                Console.WriteLine();
            }
        }
        static void jaggedArray()
        {
            int[][] studentGradesPerCourse=new int[4][];
            studentGradesPerCourse[0] = new int[3] { 60 , 29 , 62 };
            studentGradesPerCourse[1] = new int[2] { 88 , 82 };
            studentGradesPerCourse[2] = new int[2] { 77 , 44 };
            studentGradesPerCourse[3] = new int[1] { 90 };
            writeJaggedArray(studentGradesPerCourse);
        }
        static void writeJaggedArray(int[][] array)
        {
            for (int x=0;x<=array.Length-1;x++) 
            {
                for (int y = 0; y <= array[x].Length-1;y++)
                {
                    Console.Write($"{array[x][y]}\t");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("---------One Dim Array ----------");
            oneDimArray();
            Console.WriteLine("---------------------------------");
            Console.WriteLine("---------Two Dim Array ----------");
            twoDimArray();
            Console.WriteLine("---------------------------------");
            Console.WriteLine("---------Jagged Array------------");
            jaggedArray();
            Console.WriteLine("---------------------------------");
            Console.WriteLine("-----------Finished--------------");

            Console.ReadKey();
        }
    }
}
