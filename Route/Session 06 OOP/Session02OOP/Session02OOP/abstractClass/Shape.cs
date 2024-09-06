using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session02OOP.abstractClass
{
    internal abstract class Shape
    {
        public double Dim01 {get;set;}
        public double Dim02 {get;set;}
        // abstract property
        public abstract double Perimeter {get;}
        
        //Abstract method=virtual method without implmentation;
        
        public abstract double CalcArea();
    }
}
