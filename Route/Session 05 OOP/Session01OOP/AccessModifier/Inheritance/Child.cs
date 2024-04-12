using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_01
{
    public class Child:Parent
    {
        #region Proprties
        public int Z { get; set; }
        #endregion

        #region Constructors
        public Child(int _X, int _Y, int _Z) : base(_X, _Y)//Constructor Chaining
        {
            Z = _Z;
        }
        #endregion

        #region Methods
        public new int Product() //new use to hide method in parent
        {
            return base.Product() * Z; //base to access method in  parent
        }

        public override string ToString() //override on method in new parent  "Parent Class"
        {
            return $"{X} :: {Y} :: {Z} :::: {Product()}";
        } 
        #endregion

    }
}
