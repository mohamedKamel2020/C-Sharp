using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session02OOP.PolyMorephism
{
    public class Type_A
    {
        public int A { get; set; }
        public Type_A(int _A)
        {
            A = _A;
        }
        public void MyFunc1()
        {
            Console.WriteLine("This My Type A");
        }
        public virtual void MyFunc2()
        {
            Console.WriteLine($"A ={A}");
        }
    }
}
