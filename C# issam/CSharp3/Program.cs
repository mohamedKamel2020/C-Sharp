namespace CSharp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employee = new Employee[2];
            Console.Write( "TAX:");
            Employee.TAX=Convert.ToDouble(Console.ReadLine());
            Employee employee1 = new Employee();
            Console.WriteLine("First Employee");
            Console.Write("First Name: ");
            employee1.FName = Console.ReadLine();
            Console.Write("Last Name: ");
            employee1.LName = Console.ReadLine();
            Console.WriteLine("Wage: ");
            employee1.Wage=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("LoggedHours: ");
            employee1.LoggedHours=Convert.ToDouble(Console.ReadLine());
            employee[0] = employee1;
            Employee employee2 = new Employee();
            Console.WriteLine("Second Employee");
            Console.Write("First Name: ");
            employee2.FName = Console.ReadLine();
            Console.Write("Last Name: ");
            employee2.LName = Console.ReadLine();
            Console.WriteLine("Wage: ");
            employee2.Wage = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("LoggedHours: ");
            employee2.LoggedHours = Convert.ToDouble(Console.ReadLine());
            employee[1] = employee2;
            foreach (var emp in employee)
            {
                var salary = emp.Wage * emp.LoggedHours;
                var taxAmount = salary * Employee.TAX;
                var netSalary = salary - taxAmount;
                Console.WriteLine($"\nFirst Name:{emp.FName}");
                Console.WriteLine($"Last Name:{emp.LName}");
                Console.WriteLine($"Wage:{emp.Wage}");
                Console.WriteLine($"LoggedHours: {emp.LoggedHours}");
                Console.WriteLine("----------------------------");
                Console.WriteLine($"Salary:${salary}");
                Console.WriteLine($"Deductable Tax({Employee.TAX*100}%)  Amount:${taxAmount}");
                Console.WriteLine($"NetSalary:{netSalary}\n");
            }

            Console.Read();
        }
    }
}