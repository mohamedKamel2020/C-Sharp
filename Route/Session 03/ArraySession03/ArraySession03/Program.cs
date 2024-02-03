namespace ArraySession03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region One D Array
            //    //the big advantage for array "I can access element at one step within index"
            //    //the big disadvantage for array "fixed size the solve list " 
            //    //declare for reference from type array of int 
            //    //zero bytes have been allocated at heap and 4btye in stack for address
            //    //refering to default value null
            //    int[] numbers;
            //    // numbers is reference and new int[] is object
            //    numbers = new int[3]; //allocated 12 byte in heap default value for int 0
            //    numbers[0] = 1;
            //    numbers[1] = 4;
            //    numbers[2] = 6;
            //    //numbers[3] = 1;//Out of rang exception System.IndexOutOfRangeException


            //    Console.WriteLine(numbers[0]);
            //    Console.WriteLine(numbers[1]);
            //    Console.WriteLine(numbers[2]);

            //    // anthor way for array
            //    int[] numbers2 = { 7, 2, 9 };
            //    Console.WriteLine("// anthor way for array");
            //    Console.WriteLine(numbers2[0]);
            //    Console.WriteLine(numbers2[1]);
            //    Console.WriteLine(numbers2[2]);

            //    // anthor way for array
            //    int[] numbers3 =new int[3]{ 10, 4, 8};
            //    Console.WriteLine("// anthor way for array");
            //    Console.WriteLine(numbers3[0]);
            //    Console.WriteLine(numbers3[1]);
            //    Console.WriteLine(numbers3[2]);
            //    Console.WriteLine($"The size of array {numbers.Length} The number of Dimensional {numbers.Rank}");
            //int lArr;
            //Console.WriteLine("Please Enter Length of Array");
            //lArr = int.Parse(Console.ReadLine());
            //string[] Names = new string[lArr];
            //for(int i = 0; i < Names.Length; i++)
            //{
            //    Console.WriteLine($"Please Enter name No {i+1}");
            //    Names[i] = Console.ReadLine();
            //}
            //Console.Clear();
            //for(int i = 0; i < Names.Length; i++)
            //{
            //    Console.WriteLine($"The Names No ({i+1}) = {Names[i]}");
            //}

            #endregion

            #region Deeep Copy Shallow Copy
            //int[] Arr01 = { 1, 2, 3 };
            //int[] Arr02 = { 4, 5, 6 };
            //Console.WriteLine(Arr01.GetHashCode());
            //Console.WriteLine(Arr02.GetHashCode());

            ////Arr02 = Arr01;
            ////Deep Copy
            ////This object {1,2,3} has two references
            ////This object {4,5,6} unreachable object
            ////Arr01[0] = 99;
            ////Console.WriteLine(Arr02[0]);//99

            //Arr02 = (int[])Arr01.Clone();
            ////Shallow Copy
            ////Clone will generate New array with New and Different Identity 
            ////But with the copy of data of arr01={1,2,3};
            ////the object state mean data of object

            //Arr01[0] = 99;
            //Console.WriteLine(Arr02[0]);//1 not 99 because shallow copy mean take copy of data not same data with same address

            //Console.WriteLine("After Shallow Copy ");
            //Console.WriteLine(Arr01.GetHashCode());
            //Console.WriteLine(Arr02.GetHashCode());

            #endregion

            #region Two D Array - Rectangular Array
            ////way for Initial value for two D array and this array reserved 60 byte in heap 3 row *5 column =15 int *4 byte=60
            //int[,] Marks = new int[3, 5];//{ {1,2,3,4,5 },{ 1, 2, 3, 4, 5 },{ 1, 2, 3, 4, 5 } };//Two D Array [no. of rows,no. of columns]
            ////another way for Initial values for this array
            ////Marks[0, 0] = 1;
            ////Marks[0, 1] = 2;
            ////Marks[0, 2] = 3;
            ////Marks[0, 3] = 4;
            ////Marks[0, 4] = 5;
            ////Console.WriteLine($"the size of array {Marks.Length} & the no. of D {Marks.Rank}");
            ////Marks.GetLength(0) Number of Rows && Marks.GetLength(1) Number of Columns
            // bool Flag;    
            //for (int i = 0; i < Marks.GetLength(0); i++)
            //{
            //    Console.WriteLine($"Please enter the marks of student no.{i+1}");

            //   for(int j = 0; j < Marks.GetLength(1); /* j++ */)
            //    {
            //        Console.Write($"Please enter the mark for subject no ({j+1}) ");
            //        Flag=int.TryParse(Console.ReadLine(), out Marks[i,j]);
            //        //if (Flag && Marks[i,j]>=0)
            //        //    j++;
            //        j = Flag && Marks[i, j] >= 0 ? ++j : j;
            //    }
            //}
            //Console.Clear();
            //for(int i = 0; i < Marks.GetLength(0); i++)
            //{
            //    Console.WriteLine($"The Mark of Student No ({i+1})");
            //    for(int j = 0; j < Marks.GetLength(0); j++)
            //    {
            //        Console.WriteLine($"The Mark of Subject No ({j + 1})= {Marks[i,j]}");
            //    }
            //    Console.WriteLine("------------------------------------");
            //} Time of Complexity for Nested loop is N^2
            //for(int i = 0; i < Marks.Length;i++)
            //    Console.WriteLine(Marks[i/Marks.GetLength(1),i%Marks.GetLength(1)]);

            #endregion

            #region Some Functions Array
            //int[] Numbers = { 1, 10,7, 0, 8, 10, 4 };
            //int[] CopyNumbers=new int[6];
            //Array.Sort(Numbers);
            //foreach(var number in Numbers)
            //    Console.WriteLine(number);
            //Array.Reverse(Numbers);
            //foreach (var number in Numbers)
            //    Console.WriteLine(number);
            //Array.BinarySearch(Numbers, 0, 4, 8);
            //Console.WriteLine(Array.BinarySearch(Numbers, 0, 5, 8));
            //Array.Clear(Numbers);
            //foreach (var number in Numbers)
            //    Console.WriteLine(number);
            //Array.Copy(Numbers, CopyNumbers, 4);
            //foreach (var number in CopyNumbers)
            //    Console.WriteLine(number);
            //Array.ConstrainedCopy(Numbers, 1, CopyNumbers, 0, 4);
            //foreach (var number in CopyNumbers)
            //    Console.WriteLine(number);
            //Array.CreateInstance(typeof(string), 5);
            //Console.WriteLine(Array.IndexOf(Numbers, 10));
            //Console.WriteLine( Array.LastIndexOf(Numbers, 10));
            #endregion

            #region Jugged Array
            //Jugged Array One D Array of Arrays
            int[][] Numbers = new int[3][];
            Numbers[0] = new int[3] { 1, 2, 3 };
            Numbers[1] = new int[2] { 1, 2 };
            Numbers[2] = new int[1] { 1 };

            #endregion

            #region Boxing and UnBoxing
            ////Casting between Value Type and Reference Type 
            ////Cast From Value Type to Reference Type is called Implicitly or Safe Cast 
            ////Boxing
            //int x = 10;
            //object y = x;
            ////Cast From Reference Type to Value Type is called Explicitly or UnSafe Cast 
            ////UnBoxing
            //object y1 = 20;
            //int x1 = (int)y1;//if y1="Ahmed" happend exception 

            //Console.WriteLine(x1);
            #endregion

            #region Nullable Types

            //int y = 10;//Y allow Integers Value Only;

            ////y = null;Invalid  not allowed null value for value type

            //int? x = 20;//Nullable Int
            ////X allow Integers Value + Null value 
            ////using ? mark to allow nullable value
            //x = null;


            //double? num = 20.3;//Nullable Double
            //num = null;

            //int Num1 = 5;
            ////Num1 Allows Integers Only
            ////Num2 Allows Integers +Null value
            //int? Num2 = Num1; // Implicit Cast no Problem

            //int? Num3 = 10;
            //Num3 = null;
            //int M;
            //int Num4 = Num3;


            //int Num4 = (int)Num3; //Explicit Casting // Unsafe Casting
            ////If Num3=null => exception

            ////Protective Code

            //if (Num3 != null)
            //    M = (int)Num3;
            //else
            //    M = 0;
            ////Another way to Protective Code 
            //if (Num3.HasValue)
            //    M = Num3.Value;
            //else
            //    M = 0;
            ////Another way to Protective Code 
            ////Null-Coalescing Operator
            //M = Num3 ?? 0;//Syntax Suager
            //              //Conver to  if (Num3.HasValue)
            //              //M = Num3.Value;
            //              //else
            //              //M = 0;


            #endregion

            #region Null Propagation Operator
            //double Num = default;//0
            //Console.WriteLine(Num);
            //int[] Nums = default;//null

            //NullReferenceException because Nums.Length return Null and i is int not allow null
            //for(int i = 0; i < Nums.Length; i++)
            //{
            //    Console.WriteLine(Nums[i]);
            //}

            //to solve this used Null Propagation Operator Nums?.Length 
            //If Null Out If Value in

            //for(int i = 0; i < Nums?.Length; i++)
            //{
            //    Console.WriteLine(Nums[i]);
            //}

            //Nums?.Length  //syntax suager 
            //Nums != null? Nums.Length:null

            //int? Length=Nums?.Length;
            //int Length = Nums?.Length ?? 0;



            #endregion

            #region Finished
            #endregion
        }
    }
}