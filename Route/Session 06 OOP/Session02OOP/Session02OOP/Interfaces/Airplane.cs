using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session02OOP.Interfaces
{
    internal class Airplane : IMoveable, IFlyable
    {
         void IMoveable.Backward(){}
         void IMoveable.Forward(){}
         void IMoveable.Left(){}
         void IMoveable.Right() { }

         void IFlyable.Backward() { }
         void IFlyable.Forward() { }
         void IFlyable.Left() { }
         void IFlyable.Right() { }

    }
}
