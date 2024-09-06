using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session02OOP.OperatorOverloading
{
    internal class EmployeeViewModel
    {
        public string FName { get; set; }
        public string LName { get; set; }

        #region Operator Overloading
        public static /*EmployeeViewModel*/ explicit operator EmployeeViewModel(EmployeeModel employeeModel)
        {
            string[] names=employeeModel.FullName.Split(' ');
            return new EmployeeViewModel() { FName = names[0], LName=names[1] }; 
        }
        #endregion

    }
}
