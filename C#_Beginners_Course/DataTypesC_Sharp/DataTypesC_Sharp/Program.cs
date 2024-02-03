using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesC_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int employeId=0;
            string firstName=string.Empty;
            string lastName=string.Empty;
            decimal salary = 0;
            char gender = '\0';
            bool isManger=false;

            Console.WriteLine("please enter a unique Id ");
            employeId=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter employee's first name");
            firstName=Console.ReadLine();
            Console.WriteLine("please enter employee's last name");
            lastName = Console.ReadLine();
            Console.WriteLine("please enter employee's salary");
            salary = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("please enter employee's gender('f'== female and 'm'== male)");
            gender = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("The employee is a manager (true or false)");
            isManger = Convert.ToBoolean(Console.ReadLine());

            string genderTerm = (gender == 'f') ? "female" : "male";
            string managerNarrative = (isManger) ? "part of the mangement team" : "not part of the mangement team";
            string narrative = $"Employee with an Id of {employeId}";
            narrative += $"who's full name {firstName}{lastName}{Environment.NewLine}";
            narrative += $"is a {genderTerm} employee who is {managerNarrative}{Environment.NewLine}";
            narrative += $"the salary is {salary} $";
            Console.Clear();
            Console.Write(narrative+"\n");
            
            Console.WriteLine("finished");
            Console.ReadKey();


        }
    }
}
