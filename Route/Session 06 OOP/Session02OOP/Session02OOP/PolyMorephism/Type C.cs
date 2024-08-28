using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session02OOP.PolyMorephism
{
    public class Type_C:Type_B
    {
        public int C { get; set; }

        public Type_C(int _A,int _B,int _C):base(_A,_B)
        {
            C = _C;
        }
        public new void MyFunc1()
        {
            Console.WriteLine("This My Type C");
        }
        public override void MyFunc2()
        {
            Console.WriteLine($" A = {A} , B = {B}, C ={C}");
        }

    }
}
