using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStatementC_Shrap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal monyAmountInSavingsAcount = 400;
            decimal costOfBicycle = 1000;
            bool canGetLoan = true;
            decimal maxGetLoan = 400;
            if (monyAmountInSavingsAcount>=costOfBicycle) 
            {
                Console.WriteLine("i have enough mony");
            }
            else if (canGetLoan&&maxGetLoan+monyAmountInSavingsAcount>=costOfBicycle) 
            {
                Console.WriteLine("i have enough mony with loan");
            }
            else
            {
                Console.WriteLine("no have enough mony ");
            }
            Console.ReadKey();
        }
    }
}
