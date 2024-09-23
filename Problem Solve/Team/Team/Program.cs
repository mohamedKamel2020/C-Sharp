using System.Dynamic;
using System.Numerics;

namespace Team
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
                int n = int.Parse(Console.ReadLine()); // Read the number of problems

                int problemsSolved = 0;

                for (int i = 0; i < n; i++)
                {
                    string[] problemData = Console.ReadLine().Split(' '); // Read problem details

                    int petyaSure = int.Parse(problemData[0]);
                    int vasyaSure = int.Parse(problemData[1]);
                    int tonyaSure = int.Parse(problemData[2]);

                    // Check if at least two friends are sure 
                    if ((petyaSure==1 && vasyaSure==1) ||(vasyaSure==1 && tonyaSure==1)||(petyaSure==1&&tonyaSure==1)||(petyaSure==1&&tonyaSure==1&&vasyaSure==1))
                    {
                        problemsSolved++;
                    }
                }

                Console.WriteLine(problemsSolved); // Print the number of problems solved
            }
        }

    }