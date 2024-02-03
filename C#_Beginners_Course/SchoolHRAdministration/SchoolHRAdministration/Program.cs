﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRAdministrationAPI;
namespace SchoolHRAdministration
{
    public class Program
    {
        static void Main(string[] args)
        {
            decimal totalSalaries = 0;
            List<IEmployee> employees = new List<IEmployee>();
            SeedData(employees);
            //foreach (IEmployee employee in employees)
            //{
            //    totalSalaries+=employee.Salary;
            //}
            Console.WriteLine($"Total Salary :{employees.Sum(e=>e.Salary)}");
            Console.ReadKey();
        }
        public static void SeedData(List<IEmployee> employees)
        {
            IEmployee teacher1 = new Teacher
            {
                Id = 1,
                FirstName = "mohamed",
                LastName = "ahmed",
                Salary = 10
            };
            employees.Add(teacher1);

            IEmployee teacher2 = new Teacher
            {
                Id = 2,
                FirstName = "magdy",
                LastName = "ahmed",
                Salary = 12
            };
            employees.Add(teacher2);

            IEmployee headOfDepartment = new HeadOfDepartment { Id = 3, FirstName = "Brenda", LastName = "Mullins", Salary = 50000 };
            employees.Add(headOfDepartment);

            IEmployee deputyHeadMaster = new DeputyHeadMaster { Id = 4, FirstName = "Devlin", LastName = "Brown", Salary = 60000 };
            employees.Add(deputyHeadMaster);

            IEmployee headMaster = new HeadMaster { Id = 5, FirstName = "Damien", LastName = "Jones", Salary = 80000 };
            employees.Add(headMaster);

        }
    }
    
    public class Teacher : EmployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.02m); }

    }

    public class HeadOfDepartment : EmployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.03m); }
    }

    public class DeputyHeadMaster : EmployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.04m); }
    }

    public class HeadMaster : EmployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.05m); }
    }

   
    }
    
