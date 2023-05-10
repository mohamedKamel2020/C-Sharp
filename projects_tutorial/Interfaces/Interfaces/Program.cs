using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace firstNameapace
{
    public class print
    {
        public void printdata()
        {
            Console.WriteLine("printdata in first namespace");
        }
    }
}
namespace Interfaces
{
    public class print
    {
        public void printdata()
        {
            Console.WriteLine("print data in interfaces namespace");
        }
    }
    public interface ITransactions
    {
        void showTransaction();
        double getAmount();
    }

    public class Transaction : ITransactions
    {
        private string tCode;
        private string date;
        private double amount;
        public Transaction()
        {
            tCode = " ";
            date = " ";
            amount = 0.0;
        }
        public Transaction(string c, string d, double a)
        {
            tCode = c;
            date = d;
            amount = a;
        }
        public double getAmount()
        {
            return amount;
        }
        public void showTransaction()
        {
            Console.WriteLine("Transaction: {0}", tCode);
            Console.WriteLine("Date: {0}", date);
            Console.WriteLine("Amount: {0}", getAmount());
        }
    }
        internal class Program
    {
        static void Main(string[] args)
        {
            Transaction t1 = new Transaction("001", "8/10/2012", 78900.00);
            Transaction t2 = new Transaction("002", "9/10/2012", 451900.00);

            t1.showTransaction();
            t2.showTransaction();
            Console.ReadKey();
            firstNameapace.print fP=new firstNameapace.print();//declare obj(fP) of class in anthor namespace
            Interfaces.print iP=new Interfaces.print();// declare obj(Ip) of class un the same namespace
            fP.printdata();
            iP.printdata();
        }
    }
}
