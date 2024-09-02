using System.Threading.Channels;

namespace PrimeFactorization
{
    internal class Program
    {
        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));
            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }
        static void Main(string[] args)
        {
            int numeber;
            int number2;

            Console.WriteLine("Find the prime factorization of each of these integers: ");
            Console.WriteLine("Enter the number : ");

            numeber = int.Parse(Console.ReadLine());
            for(int i=2;i<= numeber; i++)
            {
                while(numeber%i == 0)
                {
                    Console.WriteLine($"{i} ");
                    numeber /= i;
                }
            }

            Console.WriteLine("**************************************");
            Console.WriteLine("Determine the number is prime or not");
            Console.WriteLine("Enter the number : ");

            number2 = int.Parse(Console.ReadLine());
           
            if (IsPrime(number2) == true)
            {
                Console.WriteLine("the number is prime");
            }
            else
            {
                Console.WriteLine("the number is not prime");
            }
       
            Console.WriteLine();
        }
       
    }
}