using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeComponent;
using EmployeeComponent.Data;
using EmployeeComponent.Views;

namespace EmployeeCRUDApp
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Employees employees = new Employees();

            EmployeeRecordsView employeeRecordsView = new EmployeeRecordsView(employees);

            Console.WriteLine(EmployeeCommonOutputText.GetApplicationHeading());

            employeeRecordsView.RunRecordsView();

            Console.ReadKey();

        }
    }
}