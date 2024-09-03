using System.Collections.Generic;

namespace LearnDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> My_dict = new Dictionary<int,string>();
            //Add element with Add() method
            My_dict.Add(1, "Welcome");
            My_dict.Add(2, "to");
            My_dict.Add(3, "Programming");
            My_dict.Add(4, "with Mo");
            Console.WriteLine("Display dict ");
            foreach(KeyValuePair<int,string> elem1 in My_dict)
            {
                //Console.WriteLine("Key = {0} and Value = {1} ",elem1.Key,elem1.Value);
                Console.WriteLine($"Key = {elem1.Key} and Value = {elem1.Value} ");
            }
            My_dict.Clear();
            Console.WriteLine("Using Clear Method ");

            foreach (KeyValuePair<int, string> elem1 in My_dict)
            {
                //Console.WriteLine("Key = {0} and Value = {1} ",elem1.Key,elem1.Value);
                Console.WriteLine($"Key = {elem1.Key} and Value = {elem1.Value} ");
            }
            //Add without Add method
            Dictionary<string, int> My_dict2 = new Dictionary<string, int>() {
                { "C#",100},
                { "C++",80},
                { "Java",140},
                { "Python",74}
            };
            Console.WriteLine("This dict before delete C++ = 80 ");
            foreach (KeyValuePair<string,int> elem2 in My_dict2)
            {
                Console.WriteLine($"Key = {elem2.Key} and Value = {elem2.Value}");
            }
            My_dict2.Remove("C++");
            Console.WriteLine("This dict After delete C++ = 80 ");
            foreach (KeyValuePair<string, int> elem2 in My_dict2)
            {
                Console.WriteLine($"Key = {elem2.Key} and Value = {elem2.Value}");
            }




        }
    }
}
