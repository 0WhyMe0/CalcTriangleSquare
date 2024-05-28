using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcTriangleSquare
{
    internal class Calculator
    {
        public double CalctriangleSquare(double ab, double bc, double ac)
        {
            double p = (ab + bc + ac) / 2;

            return Math.Sqrt(p * (p - ab) * (p - bc) * (p - ac));
        }

        public double CalctriangleSquare(double a, double h)
        {
            return 0.5 * a * h;
        }
    }
}
