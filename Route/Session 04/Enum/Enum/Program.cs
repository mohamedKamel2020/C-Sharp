namespace Enum
{
    #region Enum EX01

    //enum Gender:Byte
    //{
    //    Male,Female
    //}
    //enum Grades
    //{
    //    A=10,B,C,D=10,E,F//Labels 
    //}

    #endregion

    #region  Enum EX02
    [Flags]
    enum Permissions:byte
    {
        Write=1, Execute = 2, Read = 4,Delete=8
    }

    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Enum Ex01
            //    Grades G = Grades.A;
            //    if(G==Grades.A)
            //        Console.WriteLine("True "+G);
            //    else
            //        Console.WriteLine("False");
            //Grades Q = Grades.A;
            //Grades r = (Grades)11;
            //Console.WriteLine(Q);
            //Console.WriteLine(r);
            #endregion

            #region Enum EX02

            //Permissions MyP = (Permissions)15;
            Permissions MyP = (Permissions)6;//Excute , Read
            //If you want to add Permission Delete use XOR Operation
            MyP = MyP ^ Permissions.Delete;//7
            //MyP ^= Permissions.Delete;
            //If you want to remove Permission Read use XOR Operation
            //XOR if item is Existed Do remove ,if item is not Existed will Add
            MyP = MyP ^ Permissions.Read;
            //OR if item is Existed Do nothing, if item is not Existed will Add
            //If you want to check if Delete is Existed or not Do And Operation 
            if ( (MyP &Permissions.Delete)==Permissions.Delete)
                Console.WriteLine("Delete Permission is Existed");
            else
                Console.WriteLine("Delete Permission is not existed");


            Console.WriteLine(MyP);
            #endregion
        }
    }
}