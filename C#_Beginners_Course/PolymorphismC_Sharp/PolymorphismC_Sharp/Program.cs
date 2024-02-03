using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismC_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductBase product = new ProductBase();
            ProductBase product1 = new ProductDrived();
            ProductBase product2= new ProductAnotherDrived();
            product.getPrice();
            product2.getPrice();
            product1.getPrice();
            Console.WriteLine($"ProductBase -------- 10.00 : {product.getPrice()}");
            Console.WriteLine($"ProductDrived ------ 12.00 : {product1.getPrice()}");
            Console.WriteLine($"ProductAnotherDrived 100.0 : {product2.getPrice()}");
            
        }
    }
    public class ProductBase
    {
        public virtual decimal getPrice()
        {

            return 10.0m;
        }

    }
    public class ProductDrived : ProductBase
    {
        public override decimal getPrice()
        {

            return 12.0m;
        }

    }
    public class ProductAnotherDrived :ProductDrived
    {
        public override decimal getPrice()
        {

            return 100.0m;
        }

    }
    public abstract class Person
    {
        public abstract void Add();
    }
    //public class Mo : Person
    //{
    //    public override void Add()
    //    {
    //    }
    //}
}
