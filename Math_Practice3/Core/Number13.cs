using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Practice3.Core
{
    public class Number13
    {
        private double _a;
        private double _x;
        private double _b;

        public Number13(double a, double x, double b)
        {
            _a = a;
            _x = x;
            _b = b;
        }
        public double R()
        {
            double result = _a / _x - _a + (Math.Pow(_b, _x) + Math.Pow(Math.Cos(_x), 3)) / (Math.Pow(Math.Log10(_a), 3) + 4.5);
            Console.WriteLine(result);
            return result;
        }
    }
}
