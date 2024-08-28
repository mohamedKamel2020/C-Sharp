using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session02OOP.PolyMorephism
{
    public class Type_D:Type_C
    {
        public int D { get; set; }

        public Type_D(int _A,int _B,int _C,int _D):base(_A,_B,_C)
        {
            D = _D;
        }
        //Overriding using new keyword
        public new void MyFunc1()
        {
            Console.WriteLine("This is Type D");
        }
        //Overriding using override keyword, must be function public virtual
        public new void MyFunc2()
        {
            Console.WriteLine($"A = {A}, B = {B} ,C = {C}, D = {D}  ");
        }

    }
}
