namespace EuclideanAlgorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum , secondNum ;
            Console.WriteLine("Enter the first number");
            firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            secondNum = int.Parse(Console.ReadLine());
            while (firstNum != 0 && secondNum != 0)
            {
                Console.Write($"GCD ({firstNum},{secondNum}) = ");
                if (firstNum > secondNum)
                    firstNum %= secondNum;
                else
                    secondNum %= firstNum;
            }
            Console.Write("GCD ({0}, {1}) = {2}", firstNum, secondNum, firstNum | secondNum);
            Console.ReadKey();
        }
    }
}