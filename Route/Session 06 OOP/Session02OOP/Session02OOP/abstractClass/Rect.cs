using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session02OOP.abstractClass
{
    internal class Rect : RectBase
    {
        
        public override double Perimeter {
            get { return (Dim01 + Dim02)*2; }  }
    }
}
