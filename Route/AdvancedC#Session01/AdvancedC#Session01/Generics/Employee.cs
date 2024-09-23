using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedC_Session01.Generics
{
    internal struct Employee:IComparable<Employee>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
      
        public override string ToString()
        {
            return $"{Id} :: {Name} :: {Salary} ";
        }
        public Employee(int _id,string _name,double _salary)
        {
            this.Id = _id ;
            this.Name = _name ;
            this.Salary = _salary ;
        }
        //public override bool Equals(object? obj)
        //{
        //    Employee passedEmployee =(Employee) obj;


        //    return this.Id==passedEmployee.Id && this.Name==passedEmployee.Name && this.Salary==passedEmployee.Salary;
        //}
        public static bool operator ==(Employee left, Employee right)
        {
            return left.Equals(right);
        }
        public static bool operator !=(Employee left, Employee right)
        {
            return !(left.Equals(right));
        }

        //public int CompareTo(object? obj)
        //{
        //    Employee passedEmp = (Employee)obj;
        //    if (this.Salary > passedEmp.Salary)
        //        return 1;
        //    else if(this.Salary<passedEmp.Salary)
        //            return -1;
        //    else 
        //        return 0;
        //}

        public int CompareTo(Employee other)
        {
            if (this.Salary > other.Salary)
                return 1;
            else if (this.Salary < other.Salary)
                return -1;
            else
                return 0;
        }
    }
}
