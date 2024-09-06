using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session02OOP.abstractClass
{
    abstract class RectBase:Shape
    {
        public override double CalcArea()
        {
            return Dim01 * Dim02;
        }
    }
}
