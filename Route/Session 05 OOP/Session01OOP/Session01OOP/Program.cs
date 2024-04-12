using System.Drawing;
using MathML;
using LaTeX;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;
using Day_01;
using Assignment;

namespace Session01OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Struct Example 01
            //Point P1;
            //P1 = new Point(10,288);

            //Console.WriteLine(P1.ToString());
            //Console.WriteLine($"{P1.X} and  {P1.Y} ");

            #endregion

            #region Struct Example 02
            //PhoneBook Note = new PhoneBook(3);
            //Note.AddPerson(0, "Mohamed", 011111111);
            //Note.AddPerson(1, "Ahmed", 01222222222);
            //Note.AddPerson(2, "Aya", 0100000111111);

            //Console.WriteLine(Note.ToString());

            ////Implement Getter and Setter
            //Console.WriteLine(Note.GetPersonNumber("Aya"));
            //Note.SetPersonNumber("Mohamed", 0155555);
            //Console.WriteLine(Note.ToString());

            ////Indexer
            //Note["Mohamed"]=555;
            //Console.WriteLine(Note.ToString());
            //Console.WriteLine( Note["Mohamed"]);
            //for(int i=0; i <Note.Size;i++)
            //{
            //    Console.WriteLine(Note[i]);
            //}

            #endregion

            #region Class
            //Car C1;
            //C1 = new Car(10);
            //Console.WriteLine(C1); 
            #endregion

            #region Inheritance
            //Parent p1 = new Parent(2,3);
            //Console.WriteLine(p1);
            //Parent child = new Child(2,3,4);
            //Console.WriteLine(child); 
            #endregion

            #region Assignment
            Employee employee = new Employee(10, "Mohammed", 1000, 20, 2, 2002, Gender.Male, SecurityLevel.Developer);
            Console.WriteLine(employee);

            Employee[] emps = new Employee[2];
            for (int i = 0; i < 1; i++)
            {
                emps[i] = new Employee();
                Console.WriteLine("Please Enter ID for employee ");
                emps[i].Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please Enter Name for employee ");
                emps[i].Name = Console.ReadLine();
                Console.WriteLine("Please Enter Salary for employee ");
                emps[i].Salary = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please Enter Hire Day for employee ");
                emps[i].HiringDate.Day = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please Enter Hire month for employee ");
                emps[i].HiringDate.Month = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please Enter Hire year for employee ");
                emps[i].HiringDate.Year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please Enter Gender for employee 1 for Male , 2 for Female");
                emps[i].Gender = (Gender)Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please Enter Security Level for employee ");
                emps[i].SecurityLevel = (SecurityLevel)Convert.ToInt32(Console.ReadLine());

            }
            Console.Clear();
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine(emps[i]);
            } 
            #endregion

            #region Matrix
            //    Matrix<double> A = DenseMatrix.OfArray(new double[,] {
            //{1,1,1,1},
            //{1,2,3,4},
            //{4,3,2,1}});
            //    Vector<double>[] nullspace = A.Kernel();
            //    Console.WriteLine(A);
            #region Enter Matrix A
            //int n, m;
            //Console.WriteLine("Please enter length matrix[i,j]");
            //n=Convert.ToInt32(Console.ReadLine());
            //m=Convert.ToInt32(Console.ReadLine());
            //double[,] a =new double[n,m];
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine($"row [{i+1}]");
            //    for (int j = 0; j < m; j++)
            //    {
            //        Console.Write($"Please enter element a[{i+1},{j+1}] = ");
            //        a[i,j]=Convert.ToDouble(Console.ReadLine());
            //    }
            //}
            //var A = Matrix<double>.Build.DenseOfArray(a);

            #endregion
            #region Enter b
            //double[] b=new double[n];
            //for (int i = 0;i < n; i++)
            //{
            //    Console.WriteLine($"Enter b[{i+1}]");
            //    b[i]=Convert.ToDouble(Console.ReadLine());
            //}
            //var B = Vector<double>.Build.Dense(b);
            #endregion
            #region Solve L
            //double[,] L = new double[n,m];
            //L[0, 0] = 1;
            //L[0, 1] = 0; 
            //L[0, 2] = 0; L[0, 0] = 1; L[0, 0] = 1;
            //var x = A.Solve(B);
            #endregion

            #endregion

        }
    }
}
