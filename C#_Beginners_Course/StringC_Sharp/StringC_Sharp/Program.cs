﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringC_Sharp
{

    internal class Program
    {
        static void Main(string[] args)
        {
            string string1;
            string string2=null;
            string string3=string.Empty;
            string string4="C:\\Development\\progects";
            string string5 = @"C:\Development\progects";
            string string6 = "latest string";
            var string7 = "implicit string";
            const string string8 = "This text cannot be changed at run time";
            char[] charArray = new char[] { 'h', 'e', 'l', 'l', 'o' };
            string string9 = new string(charArray);
            Console.WriteLine(string9);
            Console.WriteLine();
            Console.WriteLine();
            int i = 12;
            decimal d = 1.2m;
            char c = 'c';
            bool b = true;
            string iString=i.ToString();
            string dString=d.ToString();
            string cString=c.ToString();
            string bString=b.ToString();
            Console.WriteLine("i = '" + iString + "' d = '" + dString + "' c = '" + cString + "' b = '" + b.ToString() + "'");
            Console.WriteLine();
            Console.WriteLine();
            string regularString = "The best Superman movie is \"Superman 2\"";
            string verbatumString =@"The best superman movie is ""Superman 2""";

            Console.WriteLine($"Regular string: {regularString}");
            Console.WriteLine($"Verbatum string: {verbatumString}");

            Console.WriteLine();
            Console.WriteLine();
            //\n new line 
            string escapeExample1 = "Superman has saved the day once again.\nSuperman is a hero";
            Console.WriteLine(escapeExample1);
            Console.WriteLine();
            ///\t tap
            string escapeExample2 = "Superman\tWonder Woman\tThe Invisible Man";
            Console.WriteLine(escapeExample2);
            Console.WriteLine();
            // \u
            string escapeExample3 = "Superman is an \u0041 grade super hero.";
            Console.WriteLine(escapeExample3);
            Console.WriteLine();
            Console.WriteLine();

            string narrative = "Superman comes from the planet, Krypton.";
            string narrative2 = narrative;

            narrative += "\nSuperman is a legal alien.";
            Console.WriteLine(narrative2);
            Console.WriteLine();
            Console.WriteLine();

            int num = 102;
            bool bln = true;

            Console.WriteLine($"It is {bln} to say that Superman can leap in a single bound over the 'Empire State Building' which is {num} stories high.");
            Console.WriteLine();

            Console.WriteLine(String.Format("It is {0} to say that Superman can leap in a single bound over the 'Empire State Building' which is {1} stories high.", bln, num));

            Console.WriteLine();
            Console.WriteLine();

            string mainString = "Superman is imperviouse to gun fire.";
            string subString = mainString.Substring(12, 10);
            string subString2 = "gun";
            string subString3 = "missile";
            Console.WriteLine(subString);
            Console.WriteLine();

            Console.WriteLine(mainString.Replace(subString2, subString3));
            Console.WriteLine();

            Console.WriteLine($"The index position of '{subString}' in our main string is {mainString.IndexOf(subString, StringComparison.OrdinalIgnoreCase)}");
            Console.WriteLine();
            Console.WriteLine();

            string superman = "Superman";

            for (int idx = 0; idx <= superman.Length - 1; idx++)
            {
                Console.Write(superman[superman.Length - idx - 1]);
            }
            Console.WriteLine();
            Console.WriteLine();

            //StringBuilder Class (StringBuilder objects are mutable)

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Superstring theory is an attempt");
            sb.AppendLine("to explain all of the particles and");
            sb.AppendLine("fundamental forces of nature in");
            sb.AppendLine("one theory by modelling them");
            sb.AppendLine("as vibrations of tiny");
            sb.AppendLine("supersymmetric strings.");

            sb[8] = 'a'; // Change character at position 8 to 'a' in the string 

            string txt = sb.ToString();

            Console.Write(txt);

            Console.ReadKey();
        }
    }
}
