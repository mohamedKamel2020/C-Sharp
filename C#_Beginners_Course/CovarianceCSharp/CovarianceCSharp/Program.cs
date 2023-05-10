using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovarianceCSharp
{
    public  class Car : CarFactory
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual string GetCarDetails()
        {
            return $"{Id} - {Name} ";
        }
    }
    public class ICECar : Car
    {
        public override string GetCarDetails()
        {
            return $"{base.GetCarDetails()} - Internal Combustion Engine";
        }
    }
    public class EVCar : Car
    {
        public override string GetCarDetails()
        {
            return $"{base.GetCarDetails()} -Electric ";
        }

    }
    public static class CarFactory
    {
        public static ICECar ReturnICECar(int id, string name)
        {
            return new ICECar { Id = id, Name = name };
        }
        public static EVCar ReturnEvCar(int id, string name)
        {
            return new EVCar { Id = id, Name = name };
        }
    }
    //    public class Small
    //    {

    //    }
    //    public class Big : Small
    //    {

    //    }
    //    public class Bigger : Big
    //    {

    //    }
    //    public delegate Small covarDell(Big mc);

    public class Program
    {
        //        public static Big Method1(Big bg)
        //        {
        //            Console.WriteLine("Method1");
        //            return new Big();
        //        }
        //        public static Small Method2(Big bg)
        //        {
        //            Console.WriteLine("Method2");
        //            return new Small();
        //        }
        //        //Contravariane is applied to parameters.
        //        //Cotravariance allows a method with the
        //        //parameter of a base class to be assigned
        //        //to a delegate that expects the parameter
        //        //of a derived class
        //        static Small Method3(Small sml)
        //        {
        //            Console.WriteLine("Method3");

        //            return new Small();
        //        }
        //        //covariance and contravariance
        //        static Big Method4(Small sml)
        //        {
        //            Console.WriteLine("Method4");
        //            return new Big();
        //        }
        public delegate Car CarFactoryDel(int id, string name);
        public delegate void LogICECarDetailsDel(ICECar car);
        public delegate void LogEVCarDetailsDel(EVCar car);

        static void Main(string[] args)
        {
            //            //covariance del As you can see in the
            //            //above example, delegate expects a
            //            //return type of small (base class)
            //            //but we can still assign Method1
            //            //that returns Big (derived class)
            //            //and also Method2 that has same signature as delegate expects.
            //            covarDell del = new covarDell(Method1);
            //            del+=Method2;
            //            del+=Method3;
            //            del+=Method4;   
            //            Small sm1 = del(new Big());
            //            //del(new Big());
            //            //del = new covarDell(Method2);
            //            ////Small sm2 = del(new Big());
            //            //del(new Big());

            CarFactoryDel carFactoryDel = new CarFactoryDel(ReturnICECar);
            Car iceCar = carFactoryDel(1, "Audi R8");
            carFactoryDel = CarFactory.ReturnEvCar;

            Car evCar = carFactoryDel(2, "Tesla Model-3");

            LogICECarDetailsDel logICECarDetailsDel = new LogICECarDetailsDel(LogCarDetails);

            logICECarDetailsDel(iceCar as ICECar);

            LogEVCarDetailsDel logEVCarDetailsDel = LogCarDetails;

            logEVCarDetailsDel(evCar as EVCar);
                        Console.ReadKey();
        }
        static void LodCarDetails(Car car)
        {
            if (car is ICECar)
            {
                using (StreamWriter sw = new StreamWriter("car.txt"))
                {
                    sw.WriteLine($"Object Type: {car.GetType()}");
                    sw.WriteLine($"Car Detials: {car.GetCarDetails()}");
                };
            }
            else if (car is EVCar)
            {
                Console.WriteLine($"Object Type: {car.GetType()}");
                Console.WriteLine($"Car Detials: {car.GetCarDetails()}");
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
    }
         
  