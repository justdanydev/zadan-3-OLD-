using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Practice3.Core
{
    public class Number20
    {
        private double _y;
        private double _x;
        private double _a;
        private double _b;
        private double _c;

        public Number20(double y, double x, double a, double b, double c)
        {
            _y = y;
            _x = x;
            _a = a;
            _b = b;
            _c = c;
        }
        public double U()
        {
            double result = (Math.Pow(Math.Tan(_y), 3) + Math.Pow(Math.Sin(_x), 5) * Math.Sqrt(_b - _c)) / (Math.Sqrt(_a - _b + _c));
            Console.WriteLine(result);
            return result;
        }
    }
}
