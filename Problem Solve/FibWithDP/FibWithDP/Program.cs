namespace FibWithDP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Program.Fib(80));
        }
        static long Fib(long n)
        {
            long[] fib=new long[n+2];
            fib[0]=0; 
            fib[1]=1;
            int i;
            for (i = 2; i <= n; i++)
            {
                fib[i] = fib[i - 1] + fib[i-2];
            }
            return fib[n];
        }
    }
}
