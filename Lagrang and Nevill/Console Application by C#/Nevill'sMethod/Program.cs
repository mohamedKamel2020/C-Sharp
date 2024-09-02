namespace Nevill_sMethod
{
    internal class Program
    {
        /* page 120 
         * 
          x0   P0 = Q0,0
          x1   P1 = Q1,0    P0,1 = Q1,1
          x2   P2 = Q2,0    P1,2 = Q2,1    P0,1,2 = Q2,2
          x3   P3 = Q3,0    P2,3 = Q3,1    P1,2,3 = Q3,2    P0,1,2,3 = Q3,3
          x4   P4 = Q4,0    P3,4 = Q4,1    P2,3,4 = Q4,2    P1,2,3,4 = Q4,3    P0,1,2,3,4 = Q4,4
         */
        static double NevilleInterpolation(double[] x, double[] y, double targetX)
        {
            int n = x.Length;
            double[,] Q = new double[n, n];

            // Initialize Q matrix with y values
            for (int i = 0; i < n; i++)
                Q[i, 0] = y[i];

            // Neville's method
            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Q[i, j] = ((targetX - x[i - j]) * Q[i, j - 1] - (targetX - x[i]) * Q[i - 1, j - 1])
                              / (x[i] - x[i - j]);
                }
            }

            
            return Q[n - 1, n - 1];
        }
        //Lagrang Polynomial
        static double LagrangMethod(double[] x, double[] y,double targetX)
        {
            double P = 0;
            double[] L=new double[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                L[i] = 1;
                for (int j = 0;j < x.Length; j++)
                {
                    if (j == i)
                        continue;
                    L[i] *= (targetX - x[j]) / (x[i] - x[j]);
                }
            }
            for(int i = 0; i < x.Length; i++)
            {
                P += L[i]*y[i];
            }
            return P;
        }
        static void Main()
        {
            // Example data points
            while (true)
            {
                int n, choice,exit;
                Console.WriteLine("Please Enter numbers of x");
                n = Convert.ToInt32(Console.ReadLine());


                double[] x = new double[n];
                double[] y = new double[n];
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"Please Enter X[{i}] ");
                    x[i] = Convert.ToDouble(Console.ReadLine());
                }
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"Please Enter F(X) = y[{i}] ");
                    y[i] = Convert.ToDouble(Console.ReadLine());
                }

                Console.WriteLine("Please Enter Point where we want to approximate f(x) ");
                double targetX = Convert.ToDouble(Console.ReadLine()); // Point where we want to approximate f(x)

                Console.WriteLine("Please Enter 1 for Approximated value by Lagrang Or 2 for Approximated value by neville ");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    double interpolatedValueByLagrang = LagrangMethod(x, y, targetX);

                    Console.WriteLine($"Approximated value by Lagrang at x = {targetX}: {interpolatedValueByLagrang}");

                }
                else if (choice == 2)
                {
                    double interpolatedValueByNeville = NevilleInterpolation(x, y, targetX);
                    Console.WriteLine($"Approximated value by neville at x = {targetX}: {interpolatedValueByNeville}");
                }
                else
                {
                    Console.WriteLine("this choice not available");
                    
                }
                Console.WriteLine("Enter -1 to exit  any another number to continue ");
                exit=Convert.ToInt32(Console.ReadLine());
                if(exit == -1) 
                {
                    Console.WriteLine("Thank you ");
                    break;
                }
            }
        }
    }
}
