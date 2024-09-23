namespace DivideTwoIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = Program.Divide(-2147483648, -1);
            
        }
        public static int Divide(int dividend, int divisor)
        {
            int c = 0;
            bool pos = true;
            double udividend;
            double udivisor;

            if (dividend > 0 && divisor > 0)
            {
                pos = true;
                udividend = dividend;
                udivisor = divisor;
            }
            else if (dividend < 0 && divisor < 0)
            {
                pos = true;
                udividend = dividend * -1;
                udivisor = divisor * -1;
            }
            else if (dividend < 0 && divisor > 0)
            {
                pos = false;
                udividend = dividend * -1;
                udivisor = divisor;
            }
            else if (dividend > 0 && divisor < 0)
            {
                pos = false;
                udividend = dividend;
                udivisor = divisor * -1;
            }
            else
            {
                udividend = dividend;
                udivisor = divisor;
            }

            while (udividend >= udivisor)
            {
                udividend = udividend - udivisor;
                c++;
            }
            if (pos == true)
            {
                return c;
            }
            else
            {
                return c * -1;
            }
        }
        /*  public static int Divide(int dividend, int divisor)
          {
              int c = 0;
              bool pos = true;
              if (dividend > 0 && divisor > 0)
              {
                  pos = true;
              }
              else if (dividend < 0 && divisor < 0)
              {
                  pos = true;
                  dividend = dividend * -1;
                  divisor = divisor * -1;
              }
              else if (dividend < 0 && divisor > 0)
              {
                  pos = false;
                  dividend = dividend * -1;
              }
              else if (dividend > 0 && divisor < 0)
              {
                  pos = false;
                  divisor = divisor * -1;
              }
              while (dividend >= divisor)
              {
                  dividend = dividend - divisor;
                  c++;
              }
              if (pos == true)
              {
                  return c;
              }
              else
              {
                  return c * -1;
              }
          }*/
    }
}
