using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session02OOP.Interfaces
{
    public class Employee:ICloneable,IComparable
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public double Salary { get; set; }
        
        public Employee(){ }
        public Employee(Employee empCopy)
        {
            this.Id = empCopy.Id;
            this.Name = empCopy.Name;
            this.Salary = empCopy.Salary;
        }
        public Employee(int _id,string _name,double _salary)
        {
            this.Id = _id;
            this.Name = _name;
            this.Salary = _salary;
        }

        
        public object Clone()
        {
            return new Employee(this);
            //this => el object ale be call 
            //return new Employee() { Id = this.Id, Name = this.Name, Salary = this.Salary };
        }

        public int CompareTo(object? obj)
        {
            Employee passedEmp = obj as Employee;
            if (this.Salary > passedEmp.Salary)
                return 1;
            else if (this.Salary < passedEmp.Salary)
                return -1;
            else
                return 0;
        }

        public override string ToString()
        {
            return $"{Id} :: {Name} :: {Salary}  ";
        }

    }
}
