using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileStreamCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // File.AppendAllText("mo.txt", "hello mohammed");
            //File.AppendAllText("mo.txt", "\nhello hager");
            //File.ReadAllText("mo.txt");
            //Console.WriteLine(File.ReadAllText("mo.txt"));
            //StreamReader data = new StreamReader("data.txt");
            //Console.WriteLine(data.ReadLine());
            //Console.WriteLine(data.ReadLine());
            //Console.WriteLine(data.ReadLine());
            //StreamWriter data = new StreamWriter("data.txt");
            //data.WriteLine("i am mohammed kamel mohammed \t learning in azhar\n");
            //data.Dispose();
            //using (StreamReader data = new StreamReader("data.txt"))
            //{
            //    Console.WriteLine(data.ReadLine());
            //}
            //using (StreamWriter data1 = new StreamWriter("data.txt")) 
            //{
            //    data1.WriteLine("i am mohammed kamel mohammed \t learning in azhar");
            //}
            //Console.WriteLine( File.ReadAllText("data.txt"));
            string[] names = { "mohammed", "ahmed", "Kamel", "Muk" };
            string[] name = { "mohammed", "ahmed", "Kamel", "Muk" };
            File.WriteAllLines( "text.txt",names);
            File.AppendAllLines("text.txt", name);
            Console.ReadKey();
        }
    }
}
