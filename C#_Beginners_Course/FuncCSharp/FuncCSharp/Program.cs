using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FuncCSharp
{
    public delegate bool Predicate<in T>(T value);
    public delegate void Print(int val);
    public delegate TResult Func<in T1,in T2,out TResult>(T1 arg1,T2 arg2);//TResult considered the return type(out parameters) T input parameter
    public delegate void Print1(int value);
    //public delegate Tresult Func<out Tresult>();
    // Func<int> getRandomNumber = () => new Random().Next(1, 100);
    // lambda expression
    public class Program
    {
        static bool IsUpperCase(string str)
        {
            return str.Equals(str.ToUpper());
        }
        static void ConsolPrint(int i)
        {
            Console.WriteLine(i);
        }
        static int Sum(int x,int y)
        {
            return x + y;
        }
        //static int Result(int X)
        //{
        //    X = 10;
        //    return X;
        //}
        static void Main(string[] args)
        {
            Action<int> printActionDel = ConsolePrint;
            //Or
            // Action<int> printActionDel = new Action<int>(ConsolePrint);
            printActionDel(10);
            Print print = ConsolPrint;
            print(10);
            int i = 10;
            // Anonymous 
            Print1 print1 = delegate (int val)
            {
                val += i;
                Console.WriteLine($"Inside Anonymous method. Value {val}");
            };
            print1(100);

            Predicate<string> isUpper = IsUpperCase;

            bool result1 = isUpper("hello world!!");

            Console.WriteLine(result1);
            //Func<int, int, int> add = Sum;
            //int result = add(10, 20);
            //Console.WriteLine(result);
            //Anonymous 
            //Func<int> Result = delegate ()
            //{
            //    Random rnd = new Random();
            //    return rnd.Next(1, 100);
            //};
            Console.ReadKey();
        }
        static void ConsolePrint(int i)
        {
            Console.WriteLine(i);
        }
    }
}
