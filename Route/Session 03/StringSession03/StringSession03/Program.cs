using System.Text;

namespace StringSession03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string is reference type but work as value type 
            //string is an Immutable type , can't change its value ,The Solving StringBuldir
            string Name1;
            //declare for reference type of String
            //ntill now refering to Default value for reference type = Null

            //Name1 = new string("Mohammed");
            Name1 = "Mohammed";//syntax sugar

            string Name2 = "Ahmed";
            Name2 = Name1;
            //Ahmed become unreachable object 
            //string Name2 work as value type 
            Name1 = "lili";
            Console.WriteLine(Name2);//cout Mohammed because work as value type
            //String is an Immutable
            string Message = "Hello";
            Console.WriteLine(Message.GetHashCode());
            Message += " Ahmed";
            Console.WriteLine("After Change");
            Console.WriteLine(Message.GetHashCode());

            //StringBuilder (the solving) is an mutable can change it's value
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Mohammed");
            Console.WriteLine(stringBuilder.GetHashCode());
            Console.WriteLine("After Change");
            stringBuilder.Append(",Hello");
            Console.WriteLine(stringBuilder.GetHashCode());
            Console.WriteLine(stringBuilder);


        }
    }
}