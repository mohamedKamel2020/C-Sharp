using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesC_Sharp
{
    class Student
    {
        int _stuId=0;
        string _firstName = string.Empty;
        string _lastName = string.Empty;
        decimal _loanAmount=0;
        char _gender = '\0';
        bool _isNew=false;
        public Student(int stuId,string firstName,string lastName ,decimal loanAmount , char gender ,bool isNew)
        {
        
            _stuId = stuId;
            _firstName = firstName;    
            _lastName = lastName;
            _loanAmount = loanAmount;
            _gender = gender;
            _isNew = isNew;

        }
        public string StudentData()
        {
            string studentData = $"stuId{_stuId},first name {_firstName}, loanAmount {_loanAmount}";

            return studentData;
        }
        public void UpdateLoanAmount(decimal loanAmount) 
        {
            _loanAmount=loanAmount;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int stuId = 0;  
            string firstName = string.Empty;    
            string lastName = string.Empty;
            decimal loanAmount = 0;
            char gender = '\0';
            bool isNew=false;
            Console.WriteLine("please enter student Id");
            stuId = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter first Name ");
            firstName =Console.ReadLine();
            Console.WriteLine("please enter last Name ");
            lastName = Console.ReadLine();
            Console.WriteLine("please enter loan amount");
            loanAmount=Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("please enter student's gender ('f'==female and 'm'==male)");
            gender =Convert.ToChar(Console.ReadLine());
            Console.WriteLine("the student is new or no");
            isNew = Convert.ToBoolean(Console.ReadLine());

            Student student = new Student(stuId,firstName,lastName,loanAmount,gender,isNew);
            Console.Clear();
            Student studentCopy = student;
            Console.WriteLine("Student Data " +student.StudentData());
            Console.WriteLine();
            Console.WriteLine("Student copy data"+studentCopy.StudentData());
            Console.WriteLine();
            Console.WriteLine("please update the student's loan amount ");
            student.UpdateLoanAmount(Convert.ToDecimal(Console.ReadLine()));
            string dividerText = "After update";
            Console.WriteLine(new string ('-',dividerText.Length));
            Console.WriteLine(dividerText);
            Console.WriteLine(new string('-', dividerText.Length));
            Console.WriteLine("Student Data " + student.StudentData());
            Console.WriteLine();
            Console.WriteLine("Student copy data" + studentCopy.StudentData());
            Console.ReadKey();
        }
    }
}
