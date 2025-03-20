using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Practice3.Core
{
    public class Number8
    {
        private double _a;
        private double _y;
        private double _c;
        private double _x;

        public Number8(double a, double y, double c, double x)
        {
            _a = a;
            _y = y;
            _c = c;
            _x = x;
        }
        public double P()
        {
            double result = (Math.Pow(_a, 5) + Math.Pow(Math.Sin(_y - _c), 4)) / (Math.Pow(Math.Sin(_x + _y), 3) + Math.Abs(_x - _y));
            Console.WriteLine(result);
            return result;
        }
    }
}
