using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritencC_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product desk = new Desk();

            desk.price = 100;

            desk.Add();
            desk.Add();

            Console.WriteLine($"Total value of desks in stock: {desk.GetTotalValueInStock()}");

            Product droneTurbo = new TurboDrone();

            droneTurbo.price = 200;

            ((Drone)droneTurbo).QuantityIncremented = 10;

            droneTurbo.Add();
            droneTurbo.Add();

            Console.WriteLine($"Total value of 'Turbo' drones in stock: {droneTurbo.GetTotalValueInStock()}");

            Product droneStandard = new StandardDrone();

            droneStandard.price = 150;

            ((Drone)droneStandard).QuantityIncremented = 5;

            droneStandard.Add();
            droneStandard.Add();
            droneStandard.Add();

            Console.WriteLine($"Total value of 'Standard' drone in stock: {droneStandard.GetTotalValueInStock()}");


            Console.ReadKey();
        }
    }
    }
    public class TurboDrone : Drone
    {

    }

    public class StandardDrone : Drone
    {

    }
    public class Drone : Product
    {
        public int QuantityIncremented { get; set; }

        public Drone()
        {
            QuantityIncremented = 1;
        }

        public override void Add()
        {
            _quantity = _quantity + QuantityIncremented;
        }

    }
    public class Desk : Product
    {
        public Desk()
        {

        }
        
    }
    public class Product
    {
        protected int _quantity = 0;
        public decimal price { get; set; }
        public Product() { }
        public virtual void Add()
        {
            _quantity++;
        }
        public void Remove()
        {
            if (_quantity > 0)
                _quantity--;
        }

        public decimal GetTotalValueInStock()
        {
            return _quantity * price;
        }
    }

