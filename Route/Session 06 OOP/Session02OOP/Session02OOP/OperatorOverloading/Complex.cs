using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session02OOP.OperatorOverloading
{
    class Complex
    {
        public int Real { get; set; }
        public int Imaginary { get; set; }
        
        #region Operator Overloading
        public static Complex operator +(Complex Left, Complex Right)
        {
            return new Complex
            {
                Real = (Left?.Real ?? 0) + (Right?.Real ?? 0),

                Imaginary = (Left?.Imaginary ?? 0) + (Right?.Imaginary ?? 0)
            };
        }

        public static Complex operator -(Complex Left, Complex Right)
        {
            return new Complex
            {
                Real = (Left?.Real ?? 0) - (Right?.Real ?? 0),

                Imaginary = (Left?.Imaginary ?? 0) - (Right?.Imaginary ?? 0)
            };
        }

        public static Complex operator ++(Complex C)
        {
            return new Complex()
            {
                Real = (C?.Real ?? 0) + 1,
                Imaginary = (C?.Imaginary ?? 0)
            };
        }


        public static Complex operator --(Complex C)
        {
            return new Complex()
            {
                Real = (C?.Real ?? 0) - 1,
                Imaginary = (C?.Imaginary ?? 0)
            };
        }

        public static bool operator >(Complex Left, Complex Right)
        {
            if ((Left?.Real ?? 0) == (Right?.Real ?? 0))
                return (Left?.Imaginary ?? 0) > (Right?.Imaginary ?? 0);
            else
                return (Left?.Real ?? 0) > (Right?.Real ?? 0);
        }

        public static bool operator <(Complex Left, Complex Right)
        {
            if ((Left?.Real ?? 0) == (Right?.Real ?? 0))
                return (Left?.Imaginary ?? 0) < (Right?.Imaginary ?? 0);
            else
                return (Left?.Real ?? 0) < (Right?.Real ?? 0);
        }

        public static /*int*/ explicit operator int(Complex C)
        {
            return C?.Real ?? 0;
        }

        public static /*string*/ explicit operator string(Complex C)
        {
            return C?.ToString() ?? String.Empty;
        }
        #endregion
      
        public override string ToString()
        {
            return $"{Real} + {Imaginary}i";
        }

    }
}
