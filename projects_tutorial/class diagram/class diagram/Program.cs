using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_diagram
{
    class preson
    {
        public int age { get; set; }
        public string name { get; set; }
        protected string address { get; set; }
        private string city { get; set; }

    }

    class student
    {
        public int rollNumber { get; set; }
        protected string studingClass { get; set;}
    }
    class customer
    {
        public int customerId { get; set; }
        public string shipingCustomer { get; set; }   
    } 
    class emp
    {
        public string department { get; set; }
        Int16 salary { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
