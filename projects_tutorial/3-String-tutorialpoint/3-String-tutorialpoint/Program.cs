using System;

namespace _3_String_tutorialpoint
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName, lastName;
            firstName = "mohamed";
            lastName = "kamel";
            char[] letters = { 'h', 'e', 'l', 'l', 'o' };
            string[] str = { "Hello", "From", "Tutorials", "Point" };
            string fullname = firstName+ "\t" + lastName;
            Console.WriteLine("Full Name :{0}", fullname);
            string greetings = new string(letters);
            Console.WriteLine("Greetings: {0}", greetings);
            string message = String.Join(" ", str);
            Console.WriteLine("Message: {0}", message);
            DateTime waiting = new DateTime(2012, 10, 10, 17, 58, 1);
            string chat = String.Format("Message sent at {0:t} on {0:D}", waiting);
            Console.WriteLine("Message: {0}", chat);


        }
    }
}
