using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session02OOP.abstractClass
{
    internal class Circle : Shape
    {
        public Circle(double Radius)
        {
            Dim01 = Dim02 = Radius;
        }

        public override double Perimeter { get { return 2*3.14*Dim01; } }

        public override double CalcArea()
        {
            return 3.14*Math.Sqrt(Dim01);
        }
    }
}
