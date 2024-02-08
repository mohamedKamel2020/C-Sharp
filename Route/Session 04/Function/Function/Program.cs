namespace Function
{
    // 1-Class
    // 2-Struct
    // 3-Interface
    // 4-Enum

    internal class Program
    {
        #region Functions

        //public static void Print()
        //{
        //    for(int i=0;i<10;i++)
        //        Console.Write("@");
        //}
        //public static void Print(int count,string pattern)
        //{
        //    for (int i = 0; i < count; i++)
        //        Console.Write($"{pattern}");
        //}
        //public static void Print(int count=5, string pattern="#")
        //{
        //    for (int i = 0; i < count; i++)
        //        Console.Write($"{pattern}");
        //}
        #endregion

        #region Value Type

        //public static void SWAP(int num1,int num2)
        //{
        //    Console.WriteLine("SWAP");
        //    int temp;
        //    temp = num1;
        //    num1 = num2;
        //    num2 = temp;
        //    Console.WriteLine($"First = {num1}");
        //    Console.WriteLine($"Second = {num2}");
        //}
        //public static void SWAP(ref int num1,ref int num2)
        //{
        //    Console.WriteLine("SWAP");
        //    int temp;
        //    temp = num1;
        //    num1 = num2;
        //    num2 = temp;

        //}

        #endregion

        #region Reference Type
        ////reference type //passing by value
        //public static int SumArr(int[] Arr)
        //{
        //    int sum = 0;
        //    Arr[0] = 100;
        //    for (int i = 0; i < Arr?.Length; i++)
        //        sum += Arr[i];
        //    return sum;
        //}

        //reference type //passing by ref
        //public static int SumArr(ref int[] Arr)
        //{
        //    int sum = 0;
        //    Arr[0] = 100;
        //    for (int i = 0; i < Arr?.Length; i++)
        //        sum += Arr[i];
        //    return sum;
        //}
        #endregion

        #region Passing By Out
        public static void SumMul(int num1,int num2,out int sumResult,out int mulResult)
        {
            sumResult = num1 + num2;
            mulResult = num1 * num2;
        }

        #endregion

        #region Params

        //public static int SumArr(params int[] arr1)
        //{
        //    int sum = 0;
        //    for (int i = 0;i < arr1.Length;i++)
        //        sum += arr1[i];
        //    return sum;
        //}
        #endregion


        //Entry Point
        static void Main(string[] args)
        {
            #region Functions
            //Print(10,"_-_"); // Passing parameter with order
            //Print(pattern: "@", count: 10);//Passing parameter with name
            //Print();
            //Console.WriteLine("Hello \n Ahmed \tNasr");// to skip \n put @ in front" "
            //string FolderPath = "C:\\Users\\Dell\\Desktop\\MY PC\\programing\\C#\\Route\\Session 04";
            //string folderPath=@"C:\Users\Dell\Desktop\MY PC\programing"
            //Console.WriteLine(FolderPath);
            //Console.WriteLine(folderPath);
            #endregion

            #region Value Type
            //int firstNum = 10;
            //int secondNum = 5;
            //Console.WriteLine($"First = {firstNum}");
            //Console.WriteLine($"Second = {secondNum}");
            //SWAP(ref firstNum,ref secondNum);
            //Console.WriteLine($"First = {firstNum}");
            //Console.WriteLine($"Second = {secondNum}");
            #endregion

            #region Reference Type


            //int[] Nums = { 1, 2, 3 };
            //SumArr(ref Nums);//passing by ref


            ////SumArr(Nums); //passing by value
            ////Console.WriteLine(sum);
            //Console.WriteLine(Nums[0]);
            #endregion

            #region Passing By Out

            //int A = 10, B = 5, sResult, mResult;

            //SumMul(A, B, out sResult, out mResult);//passing by out to use passing by ref must initialized before pass 
            //// Or // 
            ////int A = 10, B = 5;// sResult, mResult;

            ////SumMul(A, B, out int sResult, out int mResult);//passing by out
            //Console.WriteLine(sResult);
            //Console.WriteLine(mResult);
            #endregion

            #region Params
            //int sum=SumArr(1, 2, 3, 4);
            //Console.WriteLine(sum);
            #endregion
        }
    }
}