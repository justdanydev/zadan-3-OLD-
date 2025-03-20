using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Math_Practice3.Core
{
    public class Number2
    {
        private double _c;
        private double _x;
        private double _t;

        public Number2(double c, double x, double t)
        {
            _c = c;
            _x = x;
            _t = t;
        }
        public double L()
        {
            double result = Math.Pow(Math.Sin(_c) / Math.Cos(_c), 2) + (2 * Math.Pow(_x, 2) + 5) / (Math.Sqrt(_c + _t));
            Console.WriteLine(result);
            return result;
        }
    }
}
