using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCaseC_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which country has the heighst of wild?");
            string answer = Console.ReadLine();
            int score = Question1(answer);
            Console.WriteLine($"score:{score}");
            Console.ReadKey();
        }
        private static int Question1(string answer)
        {
            int score = 0;
            switch (answer.ToUpper())
            {
                case "INDIA":
                    score++;
                    Console.WriteLine("correct answer");

                    break;
                case "MALAYSIA":
                    Console.WriteLine("Malaysia do have but India have more");
                    break ;
                default:
                    Console.WriteLine("incorrect answer");
                    break;
            }
            return score;
        }
    }
}
