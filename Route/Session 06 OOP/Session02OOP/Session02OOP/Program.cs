using Session02OOP.PolyMorephism;
using Session02OOP.Interfaces;
using Session02OOP.abstractClass;
using Session02OOP.OperatorOverloading;

namespace Session02OOP
{
    internal class Program
    {
        #region Overloading

        static int Sum(int x, int y)
        {
            return x + y;
        }
        static int Sum(int x, int y, int z)
        {
            return x + y + z;
        }
        static double Sum(double x, double y)
        {
            return x + y;
        }
        static double Sum(double x, int y)
        {
            return x + y;
        }
        #endregion

        #region Interface
        static void Print10NumbersFromSeries(ISeries series)//by this i can apply open and closed
                                                            //concept from solid open for extention
                                                            //closed for modification
        {
            for(int i = 0; i <= 10; i++)
            {
                Console.Write($"{series.Current}  ");
                series.GetNext();
            }
            Console.WriteLine();
            series.Rest();//I can access for default implemented method
                          //because this reference from interface to
                          //object from class implemented this interface 
        }
        #endregion

        static void Main(string[] args)
        {
            #region PolyMorephism
            ////Overloading
            //Sum(1, 1);
            //Sum(1, 1, 1);
            //Sum(2.2, 2.2);
            //Sum(2.2,1);

            ////Overriding 
            //Type_B a = new Type_B(2,3);

            //a.MyFunc1();
            //a.MyFunc2();
            #endregion

            #region Binding
            //Type_A refBase = new Type_B(2, 1);
            //refBase.A = 11;
            ////refBase.B = 12;//Invalid
            ////2.1 static Binding call functions reference type not object type.
            //refBase.MyFunc1();//overriding by new

            ////2.2 dynamic Binding call functions object type not reference type
            //refBase.MyFunc2();//overriding by override 

            //Type_A C = new Type_C(1000, 100, 10);
            //C.A = 22;
            //C.MyFunc1();//call func for type A => static binding
            //C.MyFunc2();//call func for type C => dynamic binding


            //Type_B CformB = new Type_C(1000, 100, 10);
            //CformB.A = 22;
            //CformB.B = 222;
            ////CformB.C = 2222;//InValid
            //CformB.MyFunc1();//call func for type B => static binding
            //CformB.MyFunc2();//call func for type C => dynamic binding

            //Type_A typeA = new Type_D(1, 2, 3, 4);
            //Type_B typeB = new Type_D(1, 2, 3, 4);
            //Type_C typeC = new Type_D(1, 2, 3, 4);
            //Type_D typeD = new Type_D(1, 2, 3, 4);
            //typeA.MyFunc2();
            //typeB.MyFunc2();
            //typeC.MyFunc2();
            //typeD.MyFunc2();

            //Type_A typeA = new Type_E(1, 2, 3, 4,5);
            //Type_B typeB = new Type_E(1, 2, 3, 4,5);
            //Type_C typeC = new Type_E(1, 2, 3, 4,5);
            //Type_D typeD = new Type_E(1, 2, 3, 4,5);
            //Type_E typeE = new Type_E(1, 2, 3, 4,5);

            //typeA.MyFunc2();
            //typeB.MyFunc2();
            //typeC.MyFunc2();
            //typeD.MyFunc2();
            //typeE.MyFunc2();

            #endregion

            #region Interface

            //SeriesByTwo seriesByTwo = new SeriesByTwo();
            //Print10NumbersFromSeries(seriesByTwo);

            //SeriesByThree seriesByThree = new SeriesByThree();
            //Print10NumbersFromSeries(seriesByThree);


            //Employee employee1 = new Employee() { Id = 10, Name = "Ahmed", Salary = 10000 };//object Intializer
            //Employee employee2 = new Employee() { Id = 20, Name = "Mohamed", Salary = 20000 };

            ////Sallow Copy 
            //Console.WriteLine("Before Shallow Copy");
            //Console.WriteLine(employee1.GetHashCode());
            //Console.WriteLine(employee2.GetHashCode());
            //employee1 = employee2;
            //Console.WriteLine("After Shallow Copy");
            //Console.WriteLine(employee1.GetHashCode());
            //Console.WriteLine(employee2.GetHashCode());

            ////Deep Copy by Clone
            //Console.WriteLine("Before Deep Copy");
            //Console.WriteLine(employee1.GetHashCode());
            //Console.WriteLine(employee2.GetHashCode());
            //employee2 = (Employee)employee1.Clone();
            //Console.WriteLine("After Deep Copy");
            //Console.WriteLine(employee1.GetHashCode());
            //Console.WriteLine(employee2.GetHashCode());
            //Console.WriteLine(employee1);
            //Console.WriteLine(employee2);

            ////Deep Copy by Constructor Copy
            //Console.WriteLine("Before Deep Copy");
            //Console.WriteLine(employee1.GetHashCode());
            //Console.WriteLine(employee2.GetHashCode());
            //employee2 = new Employee(employee1);
            //Console.WriteLine("After Deep Copy");
            //Console.WriteLine(employee1.GetHashCode());
            //Console.WriteLine(employee2.GetHashCode());
            //Console.WriteLine(employee1);
            //Console.WriteLine(employee2);

            //Employee[] employees = { 
            //new Employee(10,"Ahmed" ,7000),
            //new Employee(20,"Aya"   ,4000),
            //new Employee(30,"Salah" ,5000),
            //new Employee(40,"Khaled",2000),
            //};

            ////Array.Sort(employees);

            ////foreach (Employee employee in employees)
            ////    Console.WriteLine(employee);


            //int result = employees[0].CompareTo(employees[1]);
            //if (result == -1)
            //    Console.WriteLine($"{employees[0].Name} has salary < salary for {employees[1].Name} ");
            //else if (result == 1)
            //    Console.WriteLine($"{employees[0].Name} has salary > salary for {employees[1].Name} ");
            //else
            //    Console.WriteLine($"{employees[0].Name} has salary = salary for {employees[1].Name} ");

            //Airplane airplane = new Airplane();
            ////airplane.Forward(); //this is invalid cannot access to func 

            //IFlyable airplane2 = new Airplane();
            //airplane2.Forward(); 
            #endregion

            #region Abstract 
            //Rect rect = new Rect() { Dim01 = 6, Dim02 = 6 };
            //Console.WriteLine(rect.CalcArea());
            //Circle circle = new Circle(10);
            //Console.WriteLine( circle.CalcArea());
            //Console.WriteLine(circle.Perimeter);
            #endregion

            #region Operator Overloading
            //Complex C1 = new Complex() { Real = 3, Imaginary = 2 };
            //Complex C2 = new Complex() { Real = 1, Imaginary = 4 };
            //Complex C3 = default;//null
            
            //C3 = C1 + C2;
            
            ////if (C1 > C2)
            ////    Console.WriteLine("C1 is Greater than C2");
            ////else
            ////    Console.WriteLine("C2 is Greater than C1");
            
            //C3--;

            //Console.WriteLine(C3);
            
            //int y=(int) C1;
            
            //string str= C3;

            //Console.WriteLine(y);
            //Console.WriteLine(str);
            // Casting operator Oveloading
            //EmployeeModel model = new EmployeeModel()
            //{
            //    Id = 1,
            //    FullName= "Mohamed Kamel",
            //    Password="test",
            //    SeurityStamp= "sdbbfhu432"
            //};

            //EmployeeViewModel viewModel = (EmployeeViewModel) model;
            //Console.WriteLine(viewModel.FName);
            //Console.WriteLine(viewModel.LName);
            #endregion


        }
    }
}
