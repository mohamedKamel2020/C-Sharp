using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public enum Gender:int
    {
        Male=1,Female=2
    }
    public enum SecurityLevel
    {
        Guest=1, Developer=2, Secretary=3 , DBA=4
    }

    public class Employee
    {
        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public HiringDate? HiringDate { get; set; }
        public Gender Gender { get; set; }
        public SecurityLevel SecurityLevel { get; set; }
        #endregion

        #region Constructor
        public Employee(int _id, string _name, double _salary, int _day, int _month, int _year, Gender _gender, SecurityLevel _securityLevel)
        {
            Id = _id;
            Name = _name;
            Salary = _salary;
            HiringDate = new HiringDate(_day, _month, _year);
            Gender = _gender;
            SecurityLevel = _securityLevel;

        }
        public Employee()
        {
            HiringDate = new HiringDate();
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"ID : {Id} :: Name : {Name} :: Salary : {Salary} :: Hire Date : {HiringDate.Day}/{HiringDate.Month}/{HiringDate.Year} :: Gender : {Gender} :: Security Level : {SecurityLevel} ";
        } 
        #endregion
    }
}
