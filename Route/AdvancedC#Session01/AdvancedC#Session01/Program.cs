using System.Collections;

namespace AdvancedC_Session01
{
    public delegate int StringFuncDelegate(string name);

    internal class Program
    {
        #region non-generic collections
        public static int Sum(ArrayList arrayList)
        {
            int sum = 0;
            for (int i = 0; i < arrayList.Count; i++)
            {
                sum += (int)arrayList[i];//Cast from reference type to value type UnBoxing
            }
            return sum;
        }
        #endregion

        #region Generic Collections

        public static int SumList(List<int> numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        #endregion


        static void Main(string[] args)
        {

            #region Non Generic Swap
            //    int X = 10;
            //    int Y = 20;
            //    Console.WriteLine($"X = {X}");
            //    Console.WriteLine($"Y = {Y}");
            //    Helper.Swap(ref X, ref Y);
            //    Console.WriteLine($"X = {X}");
            //    Console.WriteLine($"Y = {Y}");
            //    double dX = 10.3;
            //    double dY = 20.6;
            //    Console.WriteLine($"X = {dX}");
            //    Console.WriteLine($"Y = {dY}");
            //    Helper.Swap(ref dX, ref dY);
            //    Console.WriteLine($"X = {dX}");
            //    Console.WriteLine($"Y = {dY}");
            //    Point PX = new Point(2,2);
            //    Point PY = new Point(4 ,4);
            //    Console.WriteLine($"PX = {PX}");
            //    Console.WriteLine($"PY = {PY}");
            //    Helper.Swap(ref PX, ref PY);
            //    Console.WriteLine($"PX = {PX}");
            //    Console.WriteLine($"PY = {PY}");
            #endregion

            #region Generic Swap
            //int X = 10;
            //int Y = 20;
            //Console.WriteLine($"X = {X}");
            //Console.WriteLine($"Y = {Y}");
            ////you don't need to write type of method
            ////because compiler can deceted this from parameters
            ////this in only generic Method not generic Class or struct or Interface 
            ////Helper.Swap<int>(ref X, ref Y);
            //Helper<int>.Swap(ref X, ref Y);

            //Console.WriteLine($"X = {X}");
            //Console.WriteLine($"Y = {Y}");

            //double dX = 10.3;
            //double dY = 20.6;
            //Console.WriteLine($"X = {dX}");
            //Console.WriteLine($"Y = {dY}");
            ////Helper.Swap<double>(ref dX, ref dY);
            //Helper<double>.Swap(ref dX, ref dY);
            //Console.WriteLine($"X = {dX}");
            //Console.WriteLine($"Y = {dY}");
            //Point PX = new Point(2, 2);
            //Point PY = new Point(4, 4);
            //Console.WriteLine($"PX = {PX}");
            //Console.WriteLine($"PY = {PY}");
            ////Helper.Swap<Point>(ref PX, ref PY);
            //Helper<Point>.Swap(ref PX, ref PY);
            //Console.WriteLine($"PX = {PX}");
            //Console.WriteLine($"PY = {PY}");
            #endregion

            #region Generic

            //Employee employee01 = new Employee() { Id=  1, Name = "Mohammed",Salary=6000};
            //Employee employee02 = new Employee() { Id = 1, Name = "Mohammed", Salary = 6000 };
            //Employee employee03 = new Employee() { Id = 2, Name = "Mohammed", Salary = 6000 };
            //Employee[] employees = { employee01,employee02,employee03};
            //int ans=Helper<Employee>.SearchArray(employees, new Employee(){Id = 2, Name = "Mohammed", Salary = 6000 });
            //Console.WriteLine(ans);
            //// == operator and Equals method with class compare references "addresses"
            //if (employee01.Equals(employee02))
            //{
            //    Console.WriteLine("EQULS");
            //}
            //else
            //{
            //    Console.WriteLine("Not EQuals");
            //}
            //if (employee02.Equals(employee03)) {
            //    Console.WriteLine("EQULS");
            //}
            //else
            //{
            //    Console.WriteLine("Not EQuals");
            //}

            //Employee employee = new Employee(1,"Aye",10000);
            //Employee employee1 = new Employee(2, "Kamel", 5000);
            //Employee employee2 = new Employee(3, "Sayed", 4300);

            //Employee[] employees = { employee, employee1, employee2 };


            //Helper<Employee>.BubbleSort(employees);

            //foreach(var item in employees)
            //{
            //    Console.WriteLine(item);
            //}

            //Point[] points = {
            //    new Point(1, 2),
            //    new Point(10, 5),
            //    new Point(3, 4)
            //};

            //Helper<Point>.BubbleSort(points);

            //foreach (var item in points)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region non-generic collections
            ////non-generic collections => problem => boxing and unboxing
            //ArrayList arrayList = new ArrayList();
            //arrayList.Add(1);
            //Console.WriteLine($"using size => Count = {arrayList.Count} reversed storage => Capacity = {arrayList.Capacity} ");
            //arrayList.Add(3);
            //Console.WriteLine($"using size => Count = {arrayList.Count} reversed storage => Capacity = {arrayList.Capacity} ");
            //arrayList.Add(4);
            //arrayList.Add(5);
            //Console.WriteLine($"using size => Count = {arrayList.Count} reversed storage => Capacity = {arrayList.Capacity} ");
            //arrayList.Add(6);
            //arrayList.Add("Mohammed"); //Boxing cast from value type to referenc type 
            //                           //Compiler can't enforce type safety
            //arrayList.TrimToSize();//free unused location
            //Console.WriteLine($"using size => Count = {arrayList.Count} reversed storage => Capacity = {arrayList.Capacity} ");
            //Sum(arrayList);

            #endregion

            #region Generic collections - Listing [List]

            //List<int> Numbers = new List<int>();
            //Console.WriteLine($"Count = {Numbers.Count}, Capacity = {Numbers.Capacity} ");
            //Numbers.Add(1);
            //Numbers.Add(2);
            //Numbers.Add(3);
            //Numbers.Add(4);
            //Console.WriteLine($"Count = {Numbers.Count}, Capacity = {Numbers.Capacity} ");
            //Numbers.Add(4);
            //Console.WriteLine($"Count = {Numbers.Count}, Capacity = {Numbers.Capacity} ");
            //Numbers.TrimExcess();//free unused location
            //Console.WriteLine($"Count = {Numbers.Count}, Capacity = {Numbers.Capacity} ");
            //int sumList = SumList(Numbers);
            //Console.WriteLine(sumList);
            //LinkedList<int> linkedList=new LinkedList<int>();
            //Stack<int> stack = new Stack<int>();
            //Queue<int> queue = new Queue<int>();
            //Numbers.Add("Ahmed");//Compiler error

            #endregion

            #region Generic Collections - HashTables [Dictionary]

            //Dictionary<string, long> PhoneBook = new Dictionary<string, long>();
            //PhoneBook.Add("Mohammed", 48184);
            //PhoneBook.Add("Ahmed", 2223432);
            //if (PhoneBook.ContainsKey("Khaled"))
            //{
            //    PhoneBook["Khaled"] = 122038;//update
            //}
            //else
            //{
            //    //PhoneBook["Khaled"] = 10038;//add
            //    PhoneBook.TryAdd("Khaled", 10038); //add
            //}

            //if (!PhoneBook.TryAdd("Mai", 74744))
            //{
            //    PhoneBook["Mai"] = 845955;
            //}
            //foreach (KeyValuePair<string, long> person in PhoneBook)
            //{
            //    Console.WriteLine($"{person.Key} ::: {person.Value}");
            //}

            //Console.WriteLine(PhoneBook.TryGetValue("Sayed", out long number));
            //Console.WriteLine(number);

            //HashSet<int> set = new HashSet<int>();


            #endregion

            #region Deleget

            //StringFuncDelegate stringFuncDelegate;
            //stringFuncDelegate = StringFunction.GetUpperChar;//pointer to function 
            //stringFuncDelegate += StringFunction.GetLowerChar;//pointer to another function 
            //stringFuncDelegate -= StringFunction.GetUpperChar;//to delete pointer to this function 



            ////int result = stringFuncDelegate.Invoke("Mohamed Kamel");
            ////syntax sugar
            //int result = stringFuncDelegate("Mohamed Kamel Mohamed");//16 lower char 
            //Console.WriteLine(result);


            #endregion
        }
    }

    public class StringFunction
    {
        public static int GetUpperChar(string name)
        {
            int upperChar = 0;
            for (int i = 0; i < name?.Length; i++)
            {
                if (Char.IsUpper(name[i]))
                    upperChar++;
            }
            return upperChar;
        }

        public static int GetLowerChar(string name)
        {
            int lowerChar = 0;
            for (int i = 0; i < name?.Length; i++)
            {
                if (Char.IsLower(name[i]))
                    lowerChar++;
            }
            return lowerChar;
        }
    }
}
