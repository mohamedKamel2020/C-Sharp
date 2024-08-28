using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session02OOP.Interfaces
{
    public class Employee:ICloneable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public Employee(Employee empCopy)
        {
            this.Id = empCopy.Id;
            this.Name = empCopy.Name;
            this.Salary = empCopy.Salary;
        }
        public Employee()
        {
            
        }
        public object Clone()
        {
            return new Employee() { Id = this.Id, Name = this.Name, Salary = this.Salary };
        }

        public override string ToString()
        {
            return $"{Id} :: {Name} :: {Salary}  ";
        }
    }
}
