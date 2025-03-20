using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Practice3.Core
{
    public class Number15
    {
        private double _m;
        private double _y;

        public Number15(double m, double y)
        {
            _m = m;
            _y = y;
        }
        public double N()
        {
            double result = (Math.Pow(_m, 2) + 2.8 * _m + 0.355) / (Math.Cos(2 * _y) + 3.6);
            Console.WriteLine(result);
            return result;
        }
    }
}
