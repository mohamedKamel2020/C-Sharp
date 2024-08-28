using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session02OOP.PolyMorephism
{
    public class Type_B:Type_A
    {
        public int B { get; set; }
        public Type_B(int _A,int _B):base(_A)
        {
            B = _B;
        }
        //Overriding using new keyword
        public new void MyFunc1()
        {
            Console.WriteLine("This is Type B");
        }
        //Overriding using override keyword, must be function public virtual
        public override void MyFunc2()
        {
            Console.WriteLine($" B = {B} , A = {A} ");
        }
    }
}
