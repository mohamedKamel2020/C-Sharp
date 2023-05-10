using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_1_C_Sharp
{
    // Struct is a value type (V) Class is a reference type
    internal class Program
    {
        //public struct Employee
        //{
        //    public int id;
        //    public string firstName;
        //    public string lastName;
        //    public decimal annualSalary;
        //    public char gender;
        //    public bool isManager;
        //}
        public class Employee
        {
            public int id;
            public string firstName;
            public string lastName;
            public decimal annualSalary;
            public char gender;
            public bool isManager;
        }
        static void Main(string[] args)
        {
            Employee employee=new Employee();
            employee.id = 1;
            employee.firstName = "Mohamed";
            employee.lastName = "Ahmed";
            employee.annualSalary = 20;
            employee.gender = 'm';
            employee.isManager = false;
            Console.WriteLine($"Annual salary before update: {employee.annualSalary}");

            UpdateAnnualSalar(employee);

            Console.WriteLine($"Annual salary after update: {employee.annualSalary}");

            Console.ReadKey();
        }
        public static void UpdateAnnualSalar(Employee employee)
        {
            employee.annualSalary = 30;
        }
    }
}
