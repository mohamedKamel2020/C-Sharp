using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_01
{
    public struct Point
    {
        public int X;
        public int Y;
        public Point(int _X, int _Y)
        {
            X = _X;
            Y = _Y;
        }
        public Point(int _X)
        {
            X =Y= _X;
            
        }
        public override string ToString()
        {
            return $"{X}{Y} ";
        }
    }
}
