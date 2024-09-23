namespace FibwithRecursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program p=new Program();
            Console.WriteLine(p.Fib(80));
        }
        long Fib(long n) {
            if (n == 0 || n == 1)
                return n;
            return (Fib(n-1)+Fib(n-2));
        }
    }
}
