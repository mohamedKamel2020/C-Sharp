using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedC_Session01.Generics
{
    internal class Point: IComparable<Point>
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int _X,int _Y) { 
            X= _X;
            Y= _Y;
        } 

        public override string ToString()
        {
            return $"({X},{Y})";
        }

        //public int CompareTo(object? obj)
        //{

        //    //Point passedPoint=(Point)obj;//Unsafe Casting May throw exception
        //    //if (this.X == passedPoint.X)
        //    //    return (this.Y.CompareTo(passedPoint.Y));
        //    //else
        //    //    return (this.X.CompareTo(passedPoint.X));

        //    ////use => is Conditional operator
        //    ////return true in 3 cases
        //    ////obj is Point
        //    ////obj is object from class inheriting from Point [3DPoint]
        //    ////obj is null
        //    //if(obj is Point passPoint)
        //    //{
        //    //    if(passPoint==null) 
        //    //        return 1 ;
        //    //    if(this.X==passPoint.X)
        //    //        return this.Y.CompareTo(passPoint.Y);
        //    //    else
        //    //        return this.X.CompareTo(passPoint.X);
        //    //}
        //    //return 1;

        //    /// as Casting operator
        //    /// If casting failed ,return null . No exception thrown
        //    /// Casting will successed at just only one case => obj is Point
        //    Point passedPoint = obj as Point;
            
        //    if(passedPoint==null)
        //        return 1 ;

        //    if (this.X == passedPoint.X)
        //        return (this.Y.CompareTo(passedPoint.Y));
        //    else
        //        return (this.X.CompareTo(passedPoint.X));
               
        //}

        public int CompareTo(Point? other)
        {
            if (other == null)
                return 1;

            if (this.X == other.X)
                return (this.Y.CompareTo(other.Y));
            else
                return (this.X.CompareTo(other.X));
        }
    }
}
