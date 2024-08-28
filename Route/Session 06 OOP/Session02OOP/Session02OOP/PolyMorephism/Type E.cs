using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session02OOP.PolyMorephism
{
    public class Type_E:Type_D
    {
        public int E { get; set; }

        public Type_E(int _A, int _B, int _C, int _D,int _E) : base(_A, _B, _C,_D)
        {
            E = _E;
        }
        //Overriding using new keyword
        public new void MyFunc1()
        {
            Console.WriteLine("This is Type E");
        }
        //Overriding using override keyword, must be function public virtual
        public new void MyFunc2()
        {
            Console.WriteLine($"A = {A}, B = {B} ,C = {C}, D = {D}, E= {E}  ");
        }
    }
}
