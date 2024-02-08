namespace Enum
{
    enum Gender:Byte
    {
        Male,Female
    }
    enum Grades
    {
        A=10,B,C,D=10,E,F//Labels 
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //    Grades G = Grades.A;
            //    if(G==Grades.A)
            //        Console.WriteLine("True "+G);
            //    else
            //        Console.WriteLine("False");
            Grades Q = Grades.A;
            Grades r = (Grades)11;
            Console.WriteLine(Q);
            Console.WriteLine(r);
        }
    }
}