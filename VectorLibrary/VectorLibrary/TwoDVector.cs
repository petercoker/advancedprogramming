using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorLibrary
{
    public struct TwoDVector
    {
        public float I { get; }
        public float J { get; }

        public TwoDVector(float i, float j)
        {
            I = i;
            J = j;
        }

        public static TwoDVector operator +(TwoDVector lhs, TwoDVector rhs)
        {
            //return new TwoDVector(); Original
            //return new TwoDVector(3, 4); // version 2
            return new TwoDVector(lhs.I + rhs.I,  lhs.J + rhs.J); // version 3
        }
    }
}
