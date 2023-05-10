using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
delegate int NumChanger(int num);
namespace DelegateCSharp
{
    //public class Log
    //{
    //    public void LogTextToScreen(string text,int age)
    //    {
    //        Console.WriteLine($"{DateTime.Now} .. Name :{text} .. Age :{age}");
    //    }
    //    public void LodTextToFile(string text, int age)
    //    {
    //        using (StreamWriter sw = new StreamWriter("text.word")) 
    //        {
    //            sw.WriteLine($"{DateTime.Now} .. Name :{text} .. Age :{age}");
    //        }
    //    }
    //}
    internal class Program
    {

        //static FileStream fs;
        //static StreamWriter sw;
        //public delegate void printString(string s);
        //public static void WriteToScreen(string str)
        //{
        //    Console.WriteLine("The String is: {0}", str);
        //}
        //public static void WriteToFile(string s)
        //{
        //    fs = new FileStream("message.txt",
        //    FileMode.Append, FileAccess.Write);
        //    sw = new StreamWriter(fs);
        //    sw.WriteLine(s);
        //    sw.Flush();
        //    sw.Close();
        //    fs.Close();
        //}
        //public static void sendString(printString ps)
        //{
        //    ps("Hello World");
        //}

           static int num1 = 10;

            public static int AddNum(int p)
            {
                num1 += p;
               return num1;
        }
          public static int MultNum(int q)
            {
                num1 *= q;
                return num1;
            }
            public static int getNum()
            {
                return num1;
            }

        //public delegate void LogDel(string text,int age);
        static void Main(string[] args)
        {
            //Log log=new Log();
            //LogDel LogTextToScreenDel, LogTextToFileDel;
            //LogTextToScreenDel = new LogDel(log.LogTextToScreen);
            //LogTextToFileDel = new LogDel(log.LodTextToFile);
            //LogDel multiLodDel = LogTextToScreenDel + LogTextToFileDel;
            //try
            //{
            //    Console.WriteLine("Please enter your name");
            //    string name=Console.ReadLine();
            //    Console.WriteLine("Please enter your age");
            //    int age=Convert.ToInt32(Console.ReadLine());
            //    LogText(multiLodDel, name,age);

            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //printString ps1 = new printString(WriteToScreen);
            //printString ps2 = new printString(WriteToFile);
            //sendString(ps1);
            //sendString(ps2);

            NumChanger numTotal;
            NumChanger numAdd = new NumChanger(AddNum);
            NumChanger numMult = new NumChanger(MultNum);
            numAdd(10);
            Console.WriteLine("Value of Num: {0}", getNum());
            numMult(10);
            Console.WriteLine("Value of Num: {0}", getNum());
            numTotal = numAdd;
            numTotal += numMult;
            numTotal(10);
            Console.WriteLine($"Total:{getNum()}");
            //Action<int>[] Actions = new Action<int>[5];
            //Actions[0] = new Action<int>((x) => { Console.WriteLine("Action[0]{0}", x); });
            //Actions[1] = new Action<int>((x) => { Console.WriteLine("Action[1]{0}", x); });
            //Actions[2] = new Action<int>((x) => { Console.WriteLine("Action[2]{0}", x); });
            //Actions[3] = new Action<int>((x) => { Console.WriteLine("Action[3]{0}", x); });
            //Actions[4] = new Action<int>((x) => { Console.WriteLine("Action[4]{0}", x); });
            //ConvertToParalle(Actions);

            Console.ReadKey();
        }
        //static void LogText(LogDel logDel,string text,int age)
        //{
        //    logDel(text,age);
        //}
        //static void ConvertToParalle(Action<int>[] Actions)
        //{
        //    foreach (var Action in Actions)
        //    {
        //        // Task.Run(Action);
        //        Task.Run(() => { Action(new Random().Next(1, 10)); });
        //    }
        //}
    }
}
